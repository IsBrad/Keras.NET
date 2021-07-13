namespace Keras
{
    /// <summary>
    ///     Initializer capable of adapting its scale to the shape of weights.
    ///     With distribution = "normal", samples are drawn from a truncated normal distribution centered on zero, with stddev
    ///     = sqrt(scale / n) where n is:
    ///     number of input units in the weight tensor, if mode = "fan_in",
    ///     number of output units, if mode = "fan_out",
    ///     average of the numbers of input and output units, if mode = "fan_avg",
    ///     With distribution = "uniform", samples are drawn from a uniform distribution within[-limit, limit], with limit =
    ///     sqrt(3 * scale / n).
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class VarianceScaling : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="VarianceScaling" /> class.
        /// </summary>
        /// <param name="scale">Scaling factor (positive float).</param>
        /// <param name="mode"> One of "fan_in", "fan_out", "fan_avg".</param>
        /// <param name="distribution"> Random distribution to use. One of "normal", "uniform".</param>
        /// <param name="seed">The seed number for random generator</param>
        public VarianceScaling(float scale = 1.0f, string mode = "fan_in", string distribution = "normal",
            int? seed = null)
        {
            Parameters["scale"] = scale;
            Parameters["mode"] = mode;
            Parameters["distribution"] = distribution;
            Parameters["seed"] = seed;
            PyInstance = Instance.keras.initializers.VarianceScaling;
            Init();
        }
    }
}