﻿namespace WaveTech.Scutex.Model.Interfaces.Services
{
	public interface ILicenseManagerService
	{
		ScutexLicense GetScutexLicense();
		ScutexLicense Validate(string licenseKey, ScutexLicense scutexLicense, ClientLicense clientLicense);
	}
}