namespace Keras.Layers
{
    /// <summary>
    ///     Layer that applies an update to the cost function based input activity.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class ActivityRegularization : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ActivityRegularization" /> class.
        /// </summary>
        /// <param name="l1">L1 regularization factor (positive float).</param>
        /// <param name="l2"> L2 regularization factor (positive float).</param>
        /// <param name="input_shape">
        ///     Arbitrary. Use the keyword argument input_shape (tuple of integers, does not include the
        ///     samples axis) when using this layer as the first layer in a model.
        /// </param>
        public ActivityRegularization(float l1 = 0.0f, float l2 = 0.0f, Shape input_shape = null)
        {
            Parameters["l1"] = l1;
            Parameters["l2"] = l2;
            Parameters["input_shape"] = input_shape;
            PyInstance = Instance.keras.layers.ActivityRegularization;
            Init();
        }
    }
}