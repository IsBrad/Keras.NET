using System.Linq;

namespace Keras.Layers
{
    public class Add : Merge
    {
        public Add(params BaseLayer[] inputs)
        {
            PyInstance = Instance.keras.layers.add(inputs: inputs.Select(x => x.PyInstance).ToList());
        }
    }
}