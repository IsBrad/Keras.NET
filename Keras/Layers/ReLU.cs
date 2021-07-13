namespace Keras.Layers
{
    /// <summary>
    ///     Rectified Linear Unit activation function.
    ///     With default values, it returns element-wise max(x, 0).
    ///     Otherwise, it follows: f(x) = max_value for x >= max_value, f(x) = x for threshold &lt;= x
    ///     <max_value, f( x)= negative_slope* ( x - threshold) otherwise.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class ReLU : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ReLU" /> class.
        /// </summary>
        /// <param name="max_value">float >= 0. Maximum activation value.</param>
        /// <param name="negative_slope">float >= 0. Negative slope coefficient.</param>
        /// <param name="threshold">float. Threshold value for thresholded activation.</param>
        public ReLU(float? max_value = null, float negative_slope = 0, float threshold = 0)
        {
            Parameters["max_value"] = max_value;
            Parameters["negative_slope"] = negative_slope;
            Parameters["threshold"] = threshold;

            PyInstance = Instance.keras.layers.ReLU;
            Init();
        }
    }
}