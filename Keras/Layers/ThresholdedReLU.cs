namespace Keras.Layers
{
    /// <summary>
    ///     Thresholded Rectified Linear Unit.
    ///     It follows: f(x) = x for x > theta, f(x) = 0 otherwise.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class ThresholdedReLU : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ThresholdedReLU" /> class.
        /// </summary>
        /// <param name="theta">float >= 0. Threshold location of activation.</param>
        public ThresholdedReLU(float theta = 1)
        {
            Parameters["theta"] = theta;

            PyInstance = Instance.keras.layers.ThresholdedReLU;
            Init();
        }
    }
}