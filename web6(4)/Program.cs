//======================================= Задача №4 ========================================
//**Считайте файл различными способами. Смотрите “Пример записи файла различными способами”. 
//    Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), 
//    строку для StreamReader и массив int для BinaryReader.
//==========================================================================================

using System;
using System.IO;
using System.Diagnostics;

namespace CopySamples
{
    class Program
    {
        #region StopWatch
        private static Stopwatch StopwatchMethod ()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            return stopwatch;
        }
        #endregion
        static void Main ()
        {
            int kbyte = 1024;
            int mbyte = 1024 * kbyte;
            int size = mbyte;
            Console.WriteLine("Please wait...");
            Console.WriteLine("FileStream. Milliseconds:{0}",
                FileStreamSample(AppDomain.CurrentDomain.BaseDirectory + "bigdata0.bin", size));

            Console.WriteLine("BinaryReader. Milliseconds:{0}",
                BinaryStreamSample(AppDomain.CurrentDomain.BaseDirectory + "bigdata1.bin", size));

            Console.WriteLine("StreamReader. Milliseconds:{0}",
                StreamWriterSample(AppDomain.CurrentDomain.BaseDirectory + "bigdata2.bin", size));

            Console.WriteLine("BufferedStream. Milliseconds:{0}",
                BufferedStreamSample(AppDomain.CurrentDomain.BaseDirectory + "bigdata3.bin", size));
            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }

        #region FileStream
        static long FileStreamSample (string filename, int size)
        {
            Stopwatch stopwatch = StopwatchMethod();
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
            for (int i = 0; i < size; i++)
                fs.ReadByte();
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
        #endregion

        #region BinaryStream
        static long BinaryStreamSample (string filename, int size)
        {
            Stopwatch stopwatch = StopwatchMethod();
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            for (int i = 0; i < size; i++)
                bw.Read();
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
        #endregion

        #region StreamWriter
        static long StreamWriterSample (string filename, int size)
        {
            Stopwatch stopwatch = StopwatchMethod();
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            for (int i = 0; i < size; i++)
                sw.Read();
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
        #endregion

        #region BufferedStream
        static long BufferedStreamSample (string filename, int size)
        {
            Stopwatch stopwatch = StopwatchMethod();
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
            byte[] buffer = new byte[ size ];
            int countPart = 4;
            int bufsize = size / countPart;
            BufferedStream bs = new BufferedStream(fs, bufsize);
            for (int i = 0; i < countPart; i++)
                bs.Read(buffer, 0, bufsize);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
        #endregion
    }
}