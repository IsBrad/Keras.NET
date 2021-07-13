namespace Keras.Layers
{
    /// <summary>
    ///     Permutes the dimensions of the input according to a given pattern.    Useful for e.g.connecting RNNs and convnets
    ///     together.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class Permute : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Permute" /> class.
        /// </summary>
        /// <param name="dims">
        ///     Tuple of integers. Permutation pattern, does not include the samples dimension. Indexing starts at
        ///     1. For instance, (2, 1) permutes the first and second dimension of the input.
        /// </param>
        /// <param name="input_shape">
        ///     Arbitrary. Use the keyword argument input_shape (tuple of integers, does not include the
        ///     samples axis) when using this layer as the first layer in a model.
        /// </param>
        public Permute(int dims, Shape input_shape = null)
        {
            Parameters["dims"] = dims;
            Parameters["input_shape"] = input_shape;
            PyInstance = Instance.keras.layers.Permute;
            Init();
        }
    }
}