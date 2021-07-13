using System.Collections.Generic;
using Keras.Helper;
using Numpy;
using Python.Runtime;

namespace Keras.Datasets
{
    /// <summary>
    ///     Dataset of 25,000 movies reviews from IMDB, labeled by sentiment (positive/negative).
    ///     Reviews have been preprocessed, and each review is encoded as a sequence of word indexes (integers). For
    ///     convenience, words are indexed by overall frequency in the dataset, so that for instance the integer "3" encodes
    ///     the 3rd most frequent word in the data. This allows for quick filtering operations such as: "only consider the top
    ///     10,000 most common words, but eliminate the top 20 most common words".
    ///     As a convention, "0" does not stand for a specific word, but instead is used to encode any unknown word.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class IMDB : Base
    {
        /// <summary>
        ///     Loads the data.
        /// </summary>
        /// <param name="path">
        ///     if you do not have the data locally (at '~/.keras/datasets/' + path), it will be downloaded to this
        ///     location.
        /// </param>
        /// <param name="num_words">
        ///     integer or None. Top most frequent words to consider. Any less frequent word will appear as
        ///     oov_char value in the sequence data.
        /// </param>
        /// <param name="skip_top">
        ///     integer. Top most frequent words to ignore (they will appear as oov_char value in the sequence
        ///     data).
        /// </param>
        /// <param name="maxlen"> int. Maximum sequence length. Any longer sequence will be truncated.</param>
        /// <param name="seed"> int. Seed for reproducible data shuffling.</param>
        /// <param name="start_char">
        ///     int. The start of a sequence will be marked with this character. Set to 1 because 0 is
        ///     usually the padding character.
        /// </param>
        /// <param name="oov_char">
        ///     int. words that were cut out because of the num_words or skip_top limit will be replaced with
        ///     this character.
        /// </param>
        /// <param name="index_from"> int. Index actual words with this index and higher.</param>
        /// <returns></returns>
        public static ((NDarray, NDarray), (NDarray, NDarray)) LoadData(string path = "imdb.npz", int? num_words = null,
            int skip_top = 0, int? maxlen = null, int seed = 113,
            int start_char = 1, int oov_char = 2, int index_from = 3)
        {
            var dlist = TupleSolver.TupleToList(Instance.keras.datasets.imdb.load_data(path: path, num_words: num_words,
                skip_top: skip_top, maxlen: maxlen, seed: seed, start_char: start_char,
                oov_char: oov_char, index_from: index_from));
            return ((dlist[0], dlist[1]), (dlist[2], dlist[3]));
        }

        /// <summary>
        ///     Gets the index of the word.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public static Dictionary<string, int> GetWordIndex(string path = "imdb_word_index.json")
        {
            var result = new Dictionary<string, int>();
            var py = new PyDict((PyObject) Instance.keras.datasets.imdb.get_word_index(path: path));
            var keys = py.Keys().As<string[]>();

            foreach (var item in keys) result[item] = py[item].As<int>();

            return result;
        }
    }
}