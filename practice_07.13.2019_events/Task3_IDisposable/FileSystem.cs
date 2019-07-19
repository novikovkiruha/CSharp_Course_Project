using System;
using System.IO;

namespace practice_07._13._2019_events.Task3_IDisposable
{
    public class FileSystem : IDisposable
    {
        private readonly string text;

        private StreamWriter writer;

        public FileSystem(string text)
        {
            this.text = text;
        }

        public void CreateFile(string path)
        {
            using (this.writer = new StreamWriter(path))
                writer.Write(this.text);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            this.writer.Dispose();
        }
    }
}
