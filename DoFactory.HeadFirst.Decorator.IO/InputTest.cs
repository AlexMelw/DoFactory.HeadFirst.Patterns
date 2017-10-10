namespace DoFactory.HeadFirst.Decorator.IO
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Reflection;
    using System.Security.Cryptography;

    // InputTest test application

    class InputTest
    {
        // Utility method: convert hex string to bytes

        public static byte[] HexToBytes(string hex)
        {
            byte[] bytes = new byte[hex.Length / 2];

            for (int i = 0; i < hex.Length / 2; i++)
            {
                string code = hex.Substring(i * 2, 2);
                bytes[i] = byte.Parse(code, NumberStyles.HexNumber);
            }
            return bytes;
        }

        static void Main()
        {
            // Get fully qualified file names
            string fullyQualifiedModuleName = Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName;
            string path = Path.GetDirectoryName(fullyQualifiedModuleName);
            path = path.Substring(0, path.IndexOf(@"\bin") + 1);

            string inFile = $"{path}MyInFile.txt";
            string outFile = $"{path}MyOutFile.txt";
            string encFile = $"{path}MyEncFile.txt";

            int rdLen;
            long totLen;
            int len;
            byte[] bin;

            using (var fin = new FileStream(inFile, FileMode.Open, FileAccess.Read))
            {
                using (var fout = new FileStream(outFile, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    fout.SetLength(value: 0);

                    //Create variables to help with read and write.
                    rdLen = 0;
                    totLen = fin.Length;
                    bin = new byte[fin.Length];

                    //Read from the input file, then write directly output file.
                    while (rdLen < totLen)
                    {
                        len = fin.Read(bin, 0, 100);
                        fout.Write(bin, 0, len);
                        rdLen += len;
                    }
                }
            }

            Console.WriteLine(@"Created unencrypted MyOutFile.txt");

            // -- Now use CryptoStream as Decorator --

            using (var fin = new FileStream(inFile, FileMode.Open, FileAccess.Read))
            {
                using (var fout = new FileStream(encFile, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    fout.SetLength(0);

                    // Setup Triple DES encryption
                    var des3 = new TripleDESCryptoServiceProvider();

                    byte[] key = HexToBytes("EA81AA1D5FC1EC53E84F30AA746139EEBAFF8A9B76638895");
                    byte[] IV = HexToBytes("87AF7EA221F3FFF5");

                    // CryptoStream 'decorates' output stream
                    Console.WriteLine("\nDecorate output stream with CryptoStream...");
                    var fenc = new CryptoStream(fout, des3.CreateEncryptor(key, IV), CryptoStreamMode.Write);

                    // Read from the input file, then write encrypted to the output file
                    rdLen = 0;
                    while (rdLen < totLen)
                    {
                        len = fin.Read(bin, 0, 100);
                        fenc.Write(bin, 0, len);
                        rdLen += len;
                    }
                }
            }

            Console.WriteLine(@"Created encrypted MyEncFile.txt");

            // Wait for user
            Console.ReadKey();
        }
    }
}