using System.Collections.Generic;

namespace Indexers {
    class NotDictionary {
        List<string> words;
        List<string> definitions;

        public NotDictionary() {
            words = new List<string>();
            definitions = new List<string>();
        }
        
        public string this[string key] {
            get {
                if (words.Exists(x => x == key)) {
                    return definitions[words.FindIndex(x => x == key)];
                } else {
                    throw new KeyNotFoundException(key);
                }

            }

            set {
                if (!words.Exists(x => x == key)) {
                    words.Add(key);
                    definitions.Add(value);
                } else {
                    definitions[words.FindIndex(x => x == key)] = value;
                }
            }
        }
    }
}
