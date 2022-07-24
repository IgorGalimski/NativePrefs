@interface IOSUnityBridge

+(const char* _Nonnull)ConvertUnityStringFromNSString:(NSString* _Nonnull) string_;
+(NSString* _Nonnull)ConvertNSStringFromUnityString:(const char* _Nonnull) unityString_;

@end
