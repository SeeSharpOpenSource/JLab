using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;
using System;

namespace EasyDAQ
{
    internal class Serializer
    {
        public static void Serialize<T>(string filename, T objectToSerialize)
        {
            try
            {
                Stream stream = File.Open(filename, FileMode.OpenOrCreate);
                BinaryFormatter bFormatter = new BinaryFormatter();
                bFormatter.Serialize(stream, objectToSerialize);
                stream.Dispose();
            }
            catch (System.Runtime.Serialization.SerializationException ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        public static T DeSerialize<T>(string filename, string dllPath)
        {
            try
            {
                T objectToSerialize;
                Stream stream = File.Open(filename, FileMode.Open);
                IFormatter bFormatter = new BinaryFormatter();
                bFormatter.Binder = new UBinder() { Path = dllPath };
                objectToSerialize = (T)bFormatter.Deserialize(stream);
                stream.Dispose();
                return objectToSerialize;
            }
            catch (System.Runtime.Serialization.SerializationException ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        internal class UBinder : SerializationBinder
        {
            public string Path { get; set; }

            public override Type BindToType(string assemblyName, string typeName)
            {
                Assembly ass = Assembly.LoadFile(Path);
                return ass.GetType(typeName);
            }
        }
    }
}