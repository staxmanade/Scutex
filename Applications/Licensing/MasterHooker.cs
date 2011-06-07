﻿namespace WaveTech.Scutex.Licensing
{
	internal static class MasterHooker
	{
		public static void HookAsymEncryptionProvider()
		{
			Providers.AsymmetricEncryptionProvider.Hooker.HookAsymmetricEncryptionProvider();
		}

		public static void HookHashingProvider()
		{
			Providers.HashingProvider.Hooker.HookHashingProvider();
		}

		public static void HookObjectSerializationProvider()
		{
			Providers.ObjectSerialization.Hooker.HookObjectSerializationProvider();
		}

		public static void HookSymEncryptionProvider()
		{
			Providers.SymmetricEncryptionProvider.Hooker.HookSymmetricEncryptionProvider();
		}

		public static void HookWmiDataProvider()
		{
			Providers.WmiDataProvider.Hooker.HookWmiDataProvider();
		}

		public static void HookClientDataRepository()
		{
			Repositories.ClientDataRepository.Hooker.HookClientDataDepository();
		}

		public static void HookServices()
		{
			Services.Hooker.HookServices();
		}

		public static void HookNetworkTimeProvider()
		{
			Providers.NetworkTimeProvider.Hooker.HookNetworkTimeProvider();
		}

		public static void HookSmallStaticKeyGenerator()
		{
			Generators.StaticKeyGeneratorSmall.Hooker.HookStaticKeyGeneratorSmall();
		}

		internal static void HookDataGenerationProvider()
		{
			Providers.DataGenerationProvider.Hooker.HookDataGenerationProvider();
		}

		internal static void HookWebServicesProvider()
		{
			Providers.WebServicesProvider.Hooker.HookWebServicesProvider();
		}

		internal static void HookSharpZipLib()
		{
			ICSharpCode.SharpZipLib.Zip.FastZip fz = new ICSharpCode.SharpZipLib.Zip.FastZip();
		}

		internal static void HookAutomapper()
		{
			AutoMapper.PropertyMap pm = new AutoMapper.PropertyMap(null);
		}

		internal static void HookCompressionProvider()
		{
			Providers.CompressionProvider.Hooker.HookCompressionProvider();
		}

		internal static void HookComBypassProvider()
		{
			Providers.ComBypassProvider.Hooker.ComBypassProvider();
		}
	}
}