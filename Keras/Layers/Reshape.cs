namespace Keras.Layers
{
    /// <summary>
    ///     Reshapes an output to a certain shape.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class Reshape : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Reshape" /> class.
        /// </summary>
        /// <param name="target_shape">target shape. Tuple of integers. Does not include the batch axis.</param>
        /// <param name="input_shape">
        ///     Arbitrary, although all dimensions in the input shaped must be fixed. Use the keyword
        ///     argument input_shape (tuple of integers, does not include the batch axis) when using this layer as the first layer
        ///     in a model.
        /// </param>
        public Reshape(Shape target_shape, Shape input_shape = null)
        {
            Parameters["target_shape"] = target_shape;
            Parameters["input_shape"] = input_shape;
            PyInstance = Instance.keras.layers.Reshape;
            Init();
        }
    }
}