﻿using WaveTech.Scutex.Model.Results;

namespace WaveTech.Scutex.Model.Interfaces.Providers
{
	public interface ILicenseActiviationProvider
	{
		ActivationResult ActivateLicense(string url, string token, EncryptionInfo encryptionInfo, LicenseActivationPayload payload, ClientLicense clientLicense);
	}
}