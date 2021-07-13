using Keras.Helper;
using Numpy;

namespace Keras
{
    /// <summary>
    ///     Dataset of 11,228 newswires from Reuters, labeled over 46 topics. As with the IMDB dataset, each wire is encoded as
    ///     a sequence of word indexes (same conventions).
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class Reuters : Base
    {
        /// <summary>
        ///     Loads the data.
        /// </summary>
        /// <param name="path">The path. to load text</param>
        /// <param name="num_words">The number words.</param>
        /// <param name="skip_top">Skip top number of records.</param>
        /// <param name="maxlen">The max length.</param>
        /// <param name="test_split">The test split.</param>
        /// <param name="seed">The seed.</param>
        /// <param name="start_char">The start character.</param>
        /// <param name="oov_char">The oov character.</param>
        /// <param name="index_from">The index from.</param>
        /// <returns></returns>
        public static ((NDarray, NDarray), (NDarray, NDarray)) LoadData(string path = "reuters.npz",
            int? num_words = null, int skip_top = 0, int? maxlen = null, float test_split = 0.2f,
            int seed = 113, int start_char = 1, int oov_char = 2, int index_from = 3)
        {
            var dlist = TupleSolver.TupleToList(Instance.keras.datasets.reuters.load_data(path: path,
                num_words: num_words, skip_top: skip_top, maxlen: maxlen, test_split: test_split, seed: seed,
                start_char: start_char,
                oov_char: oov_char, index_from: index_from));
            return ((dlist[0], dlist[1]), (dlist[2], dlist[3]));
        }
    }
}