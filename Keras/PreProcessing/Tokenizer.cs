using System.Collections.Generic;
using Keras.Utils;
using Numpy.Models;
using Python.Runtime;

namespace Keras.PreProcessing
{
    public class Tokenizer : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Tokenizer" /> class.
        /// </summary>
        /// <param name="num_words">
        ///     the maximum number of words to keep, based on word frequency. Only the most common num_words-1
        ///     words will be kept.
        /// </param>
        /// <param name="filters">
        ///     a string where each element is a character that will be filtered from the texts. The default is
        ///     all punctuation, plus tabs and line breaks, minus the ' character.
        /// </param>
        /// <param name="lower"> boolean. Whether to convert the texts to lowercase.</param>
        /// <param name="split"> str. Separator for word splitting.</param>
        /// <param name="char_level"> if True, every character will be treated as a token.</param>
        /// <param name="oov_token">
        ///     if given, it will be added to word_index and used to replace out-of-vocabulary words during
        ///     text_to_sequence calls
        /// </param>
        public Tokenizer(int? num_words = null, string filters = "!\"#$%&()*+,-./:;<=>?@[\\]^_`{|}~\t\n",
            bool lower = true, string split = " ",
            bool char_level = false, int? oov_token = null, int document_count = 0)
        {
            Parameters["num_words"] = num_words;
            Parameters["filters"] = filters;
            Parameters["lower"] = lower;
            Parameters["split"] = split;
            Parameters["char_level"] = char_level;
            Parameters["oov_token"] = oov_token;
            Parameters["document_count"] = document_count;

            PyInstance = Instance.keras.preprocessing.text.Tokenizer;
        }

        public void FitOnTexts(string[] texts)
        {
            var parameters = new Dictionary<string, object>();
            parameters["texts"] = texts;

            InvokeMethod("fit_on_texts", parameters);
        }

        public void FitOnSequences(Sequence[] sequences)
        {
            var parameters = new Dictionary<string, object>();
            parameters["sequences"] = sequences;

            InvokeMethod("fit_on_sequences", parameters);
        }

        public Sequence[] TextsToSequences(string[] texts)
        {
            var parameters = new Dictionary<string, object>();
            parameters["texts"] = texts;

            var pyList = new PyList(InvokeMethod("texts_to_sequences", parameters));
            var result = new List<Sequence>();
            foreach (PyObject item in pyList) result.Add(new Sequence(item));

            return result.ToArray();
        }

        public string[] SequencesToTexts(Sequence[] sequences)
        {
            var parameters = new Dictionary<string, object>();
            parameters["sequences"] = sequences;
            var py = InvokeMethod("texts_to_sequences", parameters);
            return py.As<string[]>();
        }

        public Matrix TextsToMatrix(string[] texts, string mode = "binary")
        {
            var parameters = new Dictionary<string, object>();
            parameters["texts"] = texts;
            parameters["mode"] = mode;

            var py = InvokeMethod("texts_to_matrix", parameters);
            return new Matrix(py);
        }
    }
}