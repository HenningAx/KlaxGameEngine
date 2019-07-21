﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlaxIO.AssetManager.Serialization;
using KlaxIO.AssetManager.Serialization.TypeConverters;
using Newtonsoft.Json;

namespace KlaxCore.GameFramework.Assets.Serializer
{
	public class CEntitySerializer : CJsonSerializer
	{
		public CEntitySerializer()
		{
			m_serializerSettings = new JsonSerializerSettings();
			m_serializerSettings.Formatting = Formatting.Indented;
			m_serializerSettings.NullValueHandling = NullValueHandling.Ignore;
			m_serializerSettings.DefaultValueHandling = DefaultValueHandling.Ignore;
			m_serializerSettings.TypeNameHandling = TypeNameHandling.Auto;
			m_serializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
			m_serializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.All;
			m_serializerSettings.FloatParseHandling = FloatParseHandling.Single;
			m_serializerSettings.Converters.Add(new CVector2Converter());
			m_serializerSettings.Converters.Add(new CVector3Converter());
			m_serializerSettings.Converters.Add(new CVector4Converter());
			m_serializerSettings.Converters.Add(new CColorConverter());
			m_serializerSettings.Converters.Add(new CColor4Converter());
			m_serializerSettings.Converters.Add(new CQuaternionConverter());
			m_serializerSettings.Converters.Add(new CMatrixConverter());
			m_serializerSettings.Converters.Add(new CHashedNameConverter());
		}

		public static CEntitySerializer Instance { get; } = new CEntitySerializer();
	}
}
