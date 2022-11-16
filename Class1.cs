using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NAudio.Wave;
using WaveFileManipulator;


namespace apoj
{
    class Reverser
    {
        const int _bitsPerByte = 8;
        static int _bytesPerSample;

        internal static void Start(string path,int i)
        {
            Mp3FileReader mp3 = new Mp3FileReader(path);

            WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(mp3);
                
            string wavepath = Path.Combine("..\\", Path.GetFileName(path));
            wavepath = wavepath.Remove(wavepath.Length - 3);
            wavepath = wavepath + "wav";
            WaveFileWriter.CreateWaveFile(wavepath, pcm);

            if (!Directory.Exists("..\\reverse"))
            {
                Directory.CreateDirectory("..\\reverse");
            }
            string localFolder = Path.Combine("..\\reverse");

            string forwardsWavFilePath = wavepath;
            byte[] forwardsWavFileStreamByteArray = populateForwardsWavFileByteArray(forwardsWavFilePath);

            getWavMetadata(forwardsWavFileStreamByteArray);

            int startIndexOfDataChunk = getStartIndexOfDataChunk(forwardsWavFileStreamByteArray);

            byte[] reversedWavFileStreamByteArray = populateReversedWavFileByteArray(forwardsWavFileStreamByteArray, startIndexOfDataChunk, _bytesPerSample);

            Random random = new Random();
            
            string str = i.ToString() + ".wav";
            string reversedWavFilePath = Path.Combine(localFolder,str );
            writeReversedWavFileByteArrayToFile(reversedWavFileStreamByteArray, reversedWavFilePath);
        }

        private static void getWavMetadata(byte[] forwardsWavFileStreamByteArray)
        {
            GetRiffText(forwardsWavFileStreamByteArray);
            GetFileSize(forwardsWavFileStreamByteArray);
            GetWaveText(forwardsWavFileStreamByteArray);
            GetFmtText(forwardsWavFileStreamByteArray);
            GetLengthOfFormatData(forwardsWavFileStreamByteArray);
            GetTypeOfFormat(forwardsWavFileStreamByteArray);
            GetNumOfChannels(forwardsWavFileStreamByteArray);
            GetSampleRate(forwardsWavFileStreamByteArray);
            GetBytesPerSecond(forwardsWavFileStreamByteArray);
            GetBlockAlign(forwardsWavFileStreamByteArray);
            _bytesPerSample = GetBitsPerSample(forwardsWavFileStreamByteArray) / _bitsPerByte;
            GetListText(forwardsWavFileStreamByteArray);
            GetDataText(forwardsWavFileStreamByteArray);
            GetDataSize(forwardsWavFileStreamByteArray);
        }

        private static void writeReversedWavFileByteArrayToFile(byte[] reversedWavFileStreamByteArray, string reversedWavFilePath)
        {
            FileStream reversedFileStream = new FileStream(reversedWavFilePath, FileMode.Create, FileAccess.Write, FileShare.Write);
            reversedFileStream.Write(reversedWavFileStreamByteArray, 0, reversedWavFileStreamByteArray.Length);
            reversedFileStream.Close();
        }

        private static byte[] populateReversedWavFileByteArray(byte[] forwardsWavFileStreamByteArray, int startIndexOfDataChunk, int bytesPerSample)
        {
            byte[] forwardsArrayWithOnlyHeaders = createForwardsArrayWithOnlyHeaders(forwardsWavFileStreamByteArray, startIndexOfDataChunk);

            byte[] forwardsArrayWithOnlyAudioData = createForwardsArrayWithOnlyAudioData(forwardsWavFileStreamByteArray, startIndexOfDataChunk);

            byte[] reversedArrayWithOnlyAudioData = reverseTheForwardsArrayWithOnlyAudioData(bytesPerSample, forwardsArrayWithOnlyAudioData);

            byte[] reversedWavFileStreamByteArray = combineArrays(forwardsArrayWithOnlyHeaders, reversedArrayWithOnlyAudioData);

            return reversedWavFileStreamByteArray;
        }

        private static byte[] combineArrays(byte[] forwardsArrayWithOnlyHeaders, byte[] reversedArrayWithOnlyAudioData)
        {
            byte[] reversedWavFileStreamByteArray = new byte[forwardsArrayWithOnlyHeaders.Length + reversedArrayWithOnlyAudioData.Length];
            Array.Copy(forwardsArrayWithOnlyHeaders, reversedWavFileStreamByteArray, forwardsArrayWithOnlyHeaders.Length);
            Array.Copy(reversedArrayWithOnlyAudioData, 0, reversedWavFileStreamByteArray, forwardsArrayWithOnlyHeaders.Length, reversedArrayWithOnlyAudioData.Length);
            return reversedWavFileStreamByteArray;
        }

        private static byte[] reverseTheForwardsArrayWithOnlyAudioData(int bytesPerSample, byte[] forwardsArrayWithOnlyAudioData)
        {
            int length = forwardsArrayWithOnlyAudioData.Length;
            byte[] reversedArrayWithOnlyAudioData = new byte[length];

            int sampleIdentifier = 0;

            for (int i = 0; i < length; i++)
            {
                if (i != 0 && i % bytesPerSample == 0)
                {
                    sampleIdentifier += 2 * bytesPerSample;
                }
                int index = length - bytesPerSample - sampleIdentifier + i;
                reversedArrayWithOnlyAudioData[i] = forwardsArrayWithOnlyAudioData[index];
            }
            return reversedArrayWithOnlyAudioData;
        }

        private static byte[] createForwardsArrayWithOnlyAudioData(byte[] forwardsWavFileStreamByteArray, int startIndexOfDataChunk)
        {
            byte[] forwardsArrayWithOnlyAudioData = new byte[forwardsWavFileStreamByteArray.Length - startIndexOfDataChunk];
            Array.Copy(forwardsWavFileStreamByteArray, startIndexOfDataChunk, forwardsArrayWithOnlyAudioData, 0, forwardsWavFileStreamByteArray.Length - startIndexOfDataChunk);
            return forwardsArrayWithOnlyAudioData;
        }

        private static byte[] createForwardsArrayWithOnlyHeaders(byte[] forwardsWavFileStreamByteArray, int startIndexOfDataChunk)
        {
            byte[] forwardsArrayWithOnlyHeaders = new byte[startIndexOfDataChunk];
            Array.Copy(forwardsWavFileStreamByteArray, 0, forwardsArrayWithOnlyHeaders, 0, startIndexOfDataChunk);
            return forwardsArrayWithOnlyHeaders;
        }

        private static byte[] populateForwardsWavFileByteArray(string forwardsWavFilePath)
        {
            FileStream forwardsWavFileStream = new FileStream(forwardsWavFilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            byte[] forwardsWavFileStreamByteArray = new byte[forwardsWavFileStream.Length];
            forwardsWavFileStream.Read(forwardsWavFileStreamByteArray, 0, (int)forwardsWavFileStream.Length);
            return forwardsWavFileStreamByteArray;
        }

        private static int getStartIndexOfDataChunk(byte[] forwardsWavFileStreamByteArray)
        {
            int startIndexOfAudioData = 12;
            int charDAsciiDecimalCode = 100; //'d' //data is located at index 70 in my .wav file
            int charAAsciiDecimalCode = 97;  //'a'
            int charTAsciiDecimalCode = 116; //'t'

            int chunkSize;

            //find "data" in the byte array
            while (!(forwardsWavFileStreamByteArray[startIndexOfAudioData] == charDAsciiDecimalCode && forwardsWavFileStreamByteArray[startIndexOfAudioData + 1] == charAAsciiDecimalCode && forwardsWavFileStreamByteArray[startIndexOfAudioData + 2] == charTAsciiDecimalCode && forwardsWavFileStreamByteArray[startIndexOfAudioData + 3] == charAAsciiDecimalCode))
            {
                startIndexOfAudioData += 4;
                chunkSize = forwardsWavFileStreamByteArray[startIndexOfAudioData] + forwardsWavFileStreamByteArray[startIndexOfAudioData + 1] * 256 + forwardsWavFileStreamByteArray[startIndexOfAudioData + 2] * 65536 + forwardsWavFileStreamByteArray[startIndexOfAudioData + 3] * 16777216;
                startIndexOfAudioData += 4 + chunkSize;
            }
            startIndexOfAudioData += 8;
            return startIndexOfAudioData;
        }





        internal static ushort GetTypeOfFormat(byte[] forwardsWavFileStreamByteArray)
        {
            int startIndex = 20;
            int endIndex = 21;
            byte[] typeOfFormatByteArray = GetRelevantBytesIntoNewArray(forwardsWavFileStreamByteArray, startIndex, endIndex);
            ushort typeOfFormat = BitConverter.ToUInt16(typeOfFormatByteArray, 0);
            Console.WriteLine("Type of format (1 is PCM) = {0}", typeOfFormat);
            return typeOfFormat;
        }

        internal static void GetFmtText(byte[] forwardsWavFileStreamByteArray)
        {
            int startIndex = 12;
            int endIndex = 15;
            GetAsciiText(forwardsWavFileStreamByteArray, startIndex, endIndex);
        }

        internal static string GetWaveText(byte[] forwardsWavFileStreamByteArray)
        {
            int startIndex = 8;
            int endIndex = 11;
            return GetAsciiText(forwardsWavFileStreamByteArray, startIndex, endIndex);
        }

        internal static string GetRiffText(byte[] forwardsWavFileStreamByteArray)
        {
            int startIndex = 0;
            int endIndex = 3;
            return GetAsciiText(forwardsWavFileStreamByteArray, startIndex, endIndex);
        }

        internal static uint GetLengthOfFormatData(byte[] forwardsWavFileStreamByteArray)
        {
            int startIndex = 16;
            int endIndex = 19;
            byte[] lengthOfFormatDataByteArray = GetRelevantBytesIntoNewArray(forwardsWavFileStreamByteArray, startIndex, endIndex);
            uint lengthOfFormatData = BitConverter.ToUInt32(lengthOfFormatDataByteArray, 0);
            Console.WriteLine("Length of format data = {0}", lengthOfFormatData);
            return lengthOfFormatData;
        }

        internal static byte[] GetRelevantBytesIntoNewArray(byte[] forwardsWavFileStreamByteArray, int startIndex, int endIndex)
        {
            int length = endIndex - startIndex + 1;
            byte[] relevantBytesArray = new byte[length];
            Array.Copy(forwardsWavFileStreamByteArray, startIndex, relevantBytesArray, 0, length);
            return relevantBytesArray;
        }

        internal static uint GetFileSize(byte[] forwardsWavFileStreamByteArray)
        {
            int fileSizeStartIndex = 4;
            int fileSizeEndIndex = 7;
            byte[] fileSizeByteArray = GetRelevantBytesIntoNewArray(forwardsWavFileStreamByteArray, fileSizeStartIndex, fileSizeEndIndex);
            uint fileSize = BitConverter.ToUInt32(fileSizeByteArray, 0) + 8; //need to add the size of the 
            Console.WriteLine("File size = {0}", fileSize);
            return fileSize;
        }

        internal static string GetAsciiText(byte[] forwardsWavFileStreamByteArray, int startIndex, int endIndex)
        {
            string asciiText = "";
            for (int i = startIndex; i <= endIndex; i++)
            {
                asciiText += Convert.ToChar(forwardsWavFileStreamByteArray[i]);
            }
            Console.WriteLine(asciiText);
            return asciiText;
        }

        internal static ushort GetNumOfChannels(byte[] forwardsWavFileStreamByteArray)
        {
            int numOfChannelsStartIndex = 22;
            int numOfChannelsEndIndex = 23;
            byte[] numOfChannelsByteArray = GetRelevantBytesIntoNewArray(forwardsWavFileStreamByteArray, numOfChannelsStartIndex, numOfChannelsEndIndex);
            ushort numOfChannels = BitConverter.ToUInt16(numOfChannelsByteArray, 0); //need to add the size of the 
            Console.WriteLine("Number Of Channels = {0}", numOfChannels);
            return numOfChannels;
        }

        internal static uint GetSampleRate(byte[] forwardsWavFileStreamByteArray)
        {
            int sampleRateStartIndex = 24;
            int sampleRateEndIndex = 27;
            byte[] sampleRateByteArray = GetRelevantBytesIntoNewArray(forwardsWavFileStreamByteArray, sampleRateStartIndex, sampleRateEndIndex);
            uint sampleRate = BitConverter.ToUInt32(sampleRateByteArray, 0); //need to add the size of the 
            Console.WriteLine("Sample Rate = {0}", sampleRate);
            return sampleRate;
        }

        internal static uint GetBytesPerSecond(byte[] forwardsWavFileStreamByteArray)
        {
            int bytesPerSecondStartIndex = 28;
            int bytesPerSecondEndIndex = 31;
            byte[] bytesPerSecondByteArray = GetRelevantBytesIntoNewArray(forwardsWavFileStreamByteArray, bytesPerSecondStartIndex, bytesPerSecondEndIndex);
            uint bytesPerSecond = BitConverter.ToUInt32(bytesPerSecondByteArray, 0); //need to add the size of the 
            Console.WriteLine("Bytes Per Second = {0}", bytesPerSecond);
            return bytesPerSecond;
        }

        internal static ushort GetBlockAlign(byte[] forwardsWavFileStreamByteArray)
        {
            int blockAlignStartIndex = 32;
            int blockAlignEndIndex = 33;
            byte[] blockAlignByteArray = GetRelevantBytesIntoNewArray(forwardsWavFileStreamByteArray, blockAlignStartIndex, blockAlignEndIndex);
            ushort blockAlign = BitConverter.ToUInt16(blockAlignByteArray, 0); //need to add the size of the 
            Console.WriteLine("Block Align = {0}", blockAlign);
            return blockAlign;
        }

        internal static ushort GetBitsPerSample(byte[] forwardsWavFileStreamByteArray)
        {
            int bitsPerSampleStartIndex = 34;
            int bitsPerSampleEndIndex = 35;
            byte[] bitsPerSampleByteArray = GetRelevantBytesIntoNewArray(forwardsWavFileStreamByteArray, bitsPerSampleStartIndex, bitsPerSampleEndIndex);
            ushort bitsPerSample = BitConverter.ToUInt16(bitsPerSampleByteArray, 0); //need to add the size of the 
            Console.WriteLine("Bits Per Sample = {0}", bitsPerSample);
            return bitsPerSample;
        }

        internal static void GetDataText(byte[] forwardsWavFileStreamByteArray)
        {
            //should be these values according to http://www.topherlee.com/software/pcm-tut-wavformat.html
            //int startIndex = 36; //this is the index of "LIST" not "data" :S
            //int endIndex = 39;

            //data is located at index 70 in my .wav file
            int startIndex = 70;
            int endIndex = 73;
            GetAsciiText(forwardsWavFileStreamByteArray, startIndex, endIndex);
        }

        internal static void GetListText(byte[] forwardsWavFileStreamByteArray)
        {
            int startIndex = 36; //this is the index of "LIST"
            int endIndex = 39;
            GetAsciiText(forwardsWavFileStreamByteArray, startIndex, endIndex);
        }

        internal static uint GetDataSize(byte[] forwardsWavFileStreamByteArray)
        {
            int dataSizeStartIndex = 70;
            int dataSizeEndIndex = 73;
            byte[] dataSizeByteArray = GetRelevantBytesIntoNewArray(forwardsWavFileStreamByteArray, dataSizeStartIndex, dataSizeEndIndex);
            uint dataSize = BitConverter.ToUInt16(dataSizeByteArray, 0); //need to add the size of the 
            
            return dataSize;
        }
    }
}