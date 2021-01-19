using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace LeagueRecommendBuild.Objects.ItemRelated
{
    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class DecodeArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long[]);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            reader.Read();
            var value = new List<long>();
            while (reader.TokenType != JsonToken.EndArray)
            {
                var converter = ParseStringConverter.Singleton;
                var arrayItem = (long)converter.ReadJson(reader, typeof(long), null, serializer);
                value.Add(arrayItem);
                reader.Read();
            }
            return value.ToArray();
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (long[])untypedValue;
            writer.WriteStartArray();
            foreach (var arrayItem in value)
            {
                var converter = ParseStringConverter.Singleton;
                converter.WriteJson(writer, arrayItem, serializer);
            }
            writer.WriteEndArray();
            return;
        }

        public static readonly DecodeArrayConverter Singleton = new DecodeArrayConverter();
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "item")
            {
                return TypeEnum.Item;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            if (value == TypeEnum.Item)
            {
                serializer.Serialize(writer, "item");
                return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class SpriteConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Sprite) || t == typeof(Sprite?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "item0.png":
                    return Sprite.Item0Png;
                case "item1.png":
                    return Sprite.Item1Png;
                case "item2.png":
                    return Sprite.Item2Png;
            }
            throw new Exception("Cannot unmarshal type Sprite");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Sprite)untypedValue;
            switch (value)
            {
                case Sprite.Item0Png:
                    serializer.Serialize(writer, "item0.png");
                    return;
                case Sprite.Item1Png:
                    serializer.Serialize(writer, "item1.png");
                    return;
                case Sprite.Item2Png:
                    serializer.Serialize(writer, "item2.png");
                    return;
            }
            throw new Exception("Cannot marshal type Sprite");
        }

        public static readonly SpriteConverter Singleton = new SpriteConverter();
    }

    internal class RequiredAllyConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RequiredAlly) || t == typeof(RequiredAlly?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Ornn")
            {
                return RequiredAlly.Ornn;
            }
            throw new Exception("Cannot unmarshal type RequiredAlly");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RequiredAlly)untypedValue;
            if (value == RequiredAlly.Ornn)
            {
                serializer.Serialize(writer, "Ornn");
                return;
            }
            throw new Exception("Cannot marshal type RequiredAlly");
        }

        public static readonly RequiredAllyConverter Singleton = new RequiredAllyConverter();
    }

    public partial class Tree
    {
        [JsonProperty("header")]
        public string Header { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public enum TypeEnum { Item };

    public enum Sprite { Item0Png, Item1Png, Item2Png };

    public enum RequiredAlly { Ornn };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                TypeEnumConverter.Singleton,
                SpriteConverter.Singleton,
                RequiredAllyConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    public partial class Group
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("MaxGroupOwnable")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long MaxGroupOwnable { get; set; }


    }
}
