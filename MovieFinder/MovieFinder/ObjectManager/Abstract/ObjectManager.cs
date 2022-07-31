using Manager.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ObjectManager
{
    class Manager<T> : IEnumerable where T : IElementWithId
    {
        private List<T> list;
        private Dictionary<Guid, T> dictionary;

        public string FileName { get; set; }

        public Manager(string fileName)
        {
            this.FileName = fileName;
            list = new List<T>();
            dictionary = new Dictionary<Guid, T>();
            Load();
        }
        public void Add(T item)
        {
            list.Add(item);
            dictionary.Add(item.Id, item);
            Save();
        }
        public void Remove(T item)
        {
            list.Remove(item);
            dictionary.Remove(item.Id);
            Save();
        }
        public void Remove(Guid id)
        {
            T item = dictionary[id];
            Remove(item);
        }
        public T this[Guid id]
        {
            get
            {
                return dictionary[id];
            }
            set
            {
                if (dictionary.ContainsKey(id))
                {
                    T item = dictionary[id];
                    dictionary[id] = value;
                    list.Remove(item);
                    list.Add(value);
                }
                else
                {
                    dictionary.Add(id, value);
                    list.Add(value);
                }
                Save();
            }
        }
        public T this[int index]
        {
            get
            {
                return list[index];
            }
        }
        public bool Containst(Guid id)
        {
            return dictionary.ContainsKey(id);
        }
        public bool Containst(T item)
        {
            return Containst(item.Id);
        }
        private void Save()
        {
            Serialize(list, FileName);
        }
        private void Load()
        {
            if (File.Exists(FileName))
            {
                list = Deserialize(FileName);
                dictionary.Clear();
                foreach (T item in list)
                {
                    dictionary.Add(item.Id, item);
                }
            }
        }
        public IEnumerator GetEnumerator()
        {
            foreach (T item in list)
            {
                yield return item;
            }
        }
        private List<T> Deserialize(string a_fileName)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<T>));

            TextReader reader = new StreamReader(a_fileName);

            object obj = deserializer.Deserialize(reader);

            reader.Close();

            return (List<T>)obj;
        }
        private void Serialize(List<T> a_stations, string a_fileName)
        {
            if (File.Exists(a_fileName))
            {
                if (File.Exists("tmp.txt"))
                {
                    File.Delete("tmp.txt");
                }

                File.Move(a_fileName, "tmp.txt");
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

            using (var stream = File.OpenWrite(a_fileName))
            {
                serializer.Serialize(stream, a_stations);
            }
        }
    }
}

