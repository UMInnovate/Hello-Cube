#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Boolean UnityEngine.XR.XRSettings::get_enabled()
extern void XRSettings_get_enabled_m970BB98BF899D943776BE6EB66FE40AA9C12A902 (void);
// 0x00000002 System.String UnityEngine.XR.XRSettings::get_loadedDeviceName()
extern void XRSettings_get_loadedDeviceName_m1E091DB259635ACAE9C3B77980CDB00AC06B6D4C (void);
// 0x00000003 System.Void UnityEngine.XR.XRDevice::InvokeDeviceLoaded(System.String)
extern void XRDevice_InvokeDeviceLoaded_m3BDF6825A2A56E4923D4E6593C7BA2949B6A3581 (void);
// 0x00000004 System.Void UnityEngine.XR.XRDevice::.cctor()
extern void XRDevice__cctor_mC83C1293819B81E68EC72D01A5CC107DFE29B98C (void);
static Il2CppMethodPointer s_methodPointers[4] = 
{
	XRSettings_get_enabled_m970BB98BF899D943776BE6EB66FE40AA9C12A902,
	XRSettings_get_loadedDeviceName_m1E091DB259635ACAE9C3B77980CDB00AC06B6D4C,
	XRDevice_InvokeDeviceLoaded_m3BDF6825A2A56E4923D4E6593C7BA2949B6A3581,
	XRDevice__cctor_mC83C1293819B81E68EC72D01A5CC107DFE29B98C,
};
static const int32_t s_InvokerIndices[4] = 
{
	4255,
	4245,
	4185,
	4263,
};
extern const CustomAttributesCacheGenerator g_UnityEngine_VRModule_AttributeGenerators[];
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_UnityEngine_VRModule_CodeGenModule;
const Il2CppCodeGenModule g_UnityEngine_VRModule_CodeGenModule = 
{
	"UnityEngine.VRModule.dll",
	4,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	0,
	NULL,
	0,
	NULL,
	NULL,
	g_UnityEngine_VRModule_AttributeGenerators,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
