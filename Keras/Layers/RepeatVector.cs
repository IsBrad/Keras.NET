namespace Keras.Layers
{
    /// <summary>
    ///     Repeats the input n times.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class RepeatVector : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RepeatVector" /> class.
        /// </summary>
        /// <param name="n">integer, repetition factor.</param>
        /// <param name="input_shape">2D tensor of shape (num_samples, features).</param>
        public RepeatVector(int n, Shape input_shape = null)
        {
            Parameters["n"] = n;
            Parameters["input_shape"] = input_shape;
            PyInstance = Instance.keras.layers.RepeatVector;
            Init();
        }
    }
}