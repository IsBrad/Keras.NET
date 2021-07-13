namespace Keras.Layers
{
    /// <summary>
    ///     Masks a sequence by using a mask value to skip timesteps.
    ///     If all features for a given sample timestep are equal to mask_value, then the sample timestep will be
    ///     masked(skipped) in all downstream layers(as long as they support masking).
    ///     If any downstream layer does not support masking yet receives such an input mask, an exception will be raised.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class Masking : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Masking" /> class.
        /// </summary>
        /// <param name="mask_value">Either None or mask value to skip</param>
        public Masking(float mask_value = 0.0f)
        {
            Parameters["mask_value"] = mask_value;
            PyInstance = Instance.keras.layers.Masking;
            Init();
        }
    }
}