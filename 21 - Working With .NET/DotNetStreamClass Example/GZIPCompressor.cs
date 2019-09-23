using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace StreamTester
{
    public static class GZIPCompressor
    {
        public static void Compress(String path, Stream memStream)
        {
            using (memStream)
            {
                using (FileStream compressedFileStream = File.Create(path))
                {
                    using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        memStream.CopyTo(compressionStream);
                    }
                }
            }
        }
    }
}