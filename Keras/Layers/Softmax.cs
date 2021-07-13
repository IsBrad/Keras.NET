namespace Keras.Layers
{
    /// <summary>
    ///     Softmax activation function.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class Softmax : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Softmax" /> class.
        /// </summary>
        /// <param name="axis"> Integer, axis along which the softmax normalization is applied.</param>
        public Softmax(int axis = -1)
        {
            Parameters["axis"] = axis;

            PyInstance = Instance.keras.layers.Softmax;
            Init();
        }
    }
}