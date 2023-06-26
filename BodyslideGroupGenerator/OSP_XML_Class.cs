using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace BodyslideGroupGenerator
{
	[XmlRoot(ElementName = "OutputFile")]
	public class OutputFile
	{
		[XmlAttribute(AttributeName = "GenWeights")]
		public string? GenWeights { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "Shape")]
	public class Shape
	{
		[XmlAttribute(AttributeName = "target")]
		public string? Target { get; set; }
		[XmlAttribute(AttributeName = "DataFolder")]
		public string? DataFolder { get; set; }
		[XmlText]
		public string? Text { get; set; }
		[XmlAttribute(AttributeName = "LockNormals")]
		public string? LockNormals { get; set; }
	}

	[XmlRoot(ElementName = "Data")]
	public class Data
	{
		[XmlAttribute(AttributeName = "name")]
		public string? Name { get; set; }
		[XmlAttribute(AttributeName = "target")]
		public string? Target { get; set; }
		[XmlAttribute(AttributeName = "local")]
		public string? Local { get; set; }
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "Slider")]
	public class Slider
	{
		[XmlElement(ElementName = "Data")]
		public List<Data>? Data { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string? Name { get; set; }
		[XmlAttribute(AttributeName = "invert")]
		public string? Invert { get; set; }
		[XmlAttribute(AttributeName = "small")]
		public string? Small { get; set; }
		[XmlAttribute(AttributeName = "big")]
		public string? Big { get; set; }
		[XmlAttribute(AttributeName = "uv")]
		public string? Uv { get; set; }
		[XmlAttribute(AttributeName = "hidden")]
		public string? Hidden { get; set; }
		[XmlAttribute(AttributeName = "zap")]
		public string? Zap { get; set; }
		[XmlAttribute(AttributeName = "zaptoggles")]
		public string? Zaptoggles { get; set; }
		[XmlAttribute(AttributeName = "default")]
		public string? Default { get; set; }
	}

	[XmlRoot(ElementName = "SliderSet")]
	public class SliderSet
	{
		[XmlElement(ElementName = "DataFolder")]
		public string? DataFolder { get; set; }
		[XmlElement(ElementName = "SourceFile")]
		public string? SourceFile { get; set; }
		[XmlElement(ElementName = "OutputPath")]
		public string? OutputPath { get; set; }
		[XmlElement(ElementName = "OutputFile")]
		public OutputFile? OutputFile { get; set; }
		[XmlElement(ElementName = "Shape")]
		public List<Shape>? Shape { get; set; }
		[XmlElement(ElementName = "Slider")]
		public List<Slider>? Slider { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string? Name { get; set; }
	}

	[XmlRoot(ElementName = "SliderSetInfo")]
	public class SliderSetInfo
	{
		[XmlElement(ElementName = "SliderSet")]
		public List<SliderSet>? SliderSet { get; set; }
		[XmlAttribute(AttributeName = "version")]
		public string? Version { get; set; }

		public static SliderSetInfo? GetOSP(string path)
        {
			XmlSerializer serializer = new XmlSerializer(typeof(SliderSetInfo));
			SliderSetInfo? i;
			using (Stream reader = new FileStream(path, FileMode.Open))
			{
				// Call the Deserialize method to restore the object's state.
				i = serializer.Deserialize(reader) as SliderSetInfo;
			}
			return i;
		}
	}
}
