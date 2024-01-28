using Newtonsoft.Json;

namespace AutoMapperSample.Helpers
{
    /// <summary>
    /// JsonProperty lari bir xil bo'lgan objectlarni map qiladi
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <typeparam name="TDestination"></typeparam>
    public class IntermediateJsonTypeConverter<TSource, TDestination>
    {
        public TDestination Convert(TSource source)
        {
            var c = JsonConvert.SerializeObject(source);

            return JsonConvert.DeserializeObject<TDestination>(c);
        }
    }

}
