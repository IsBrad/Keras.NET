using Numpy;

namespace Keras.Layers
{
    /// <summary>
    ///     Bidirectional wrapper for RNNs.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class Bidirectional : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Bidirectional" /> class.
        /// </summary>
        /// <param name="layer">The recurrent layer instance.</param>
        /// <param name="merge_mode">
        ///     Mode by which outputs of the forward and backward RNNs will be combined. One of {'sum', 'mul',
        ///     'concat', 'ave', None}. If None, the outputs will not be combined, they will be returned as a list.
        /// </param>
        /// <param name="weights">Initial weights to load in the Bidirectional model.</param>
        public Bidirectional(BaseLayer layer, string merge_mode = "concat", NDarray weights = null)
        {
            Parameters["layer"] = layer.PyInstance;

            PyInstance = Instance.keras.layers.Bidirectional;
            Init();
        }
    }
}