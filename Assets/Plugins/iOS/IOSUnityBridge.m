
@implementation IOSUnityBridge

+(const char* _Nonnull)ConvertUnityStringFromNSString:(NSString* _Nonnull) string_ {
    NSString *string = (string_.length>0) ? string_ : [NSString new];
    const char* cString = string.UTF8String;
    char* _unityString = (char*)malloc(strlen(cString) + 1);
    strcpy(_unityString, cString);
    return _unityString;
}

+(NSString* _Nonnull)ConvertNSStringFromUnityString:(const char* _Nonnull) unityString_ {
    if (unityString_ == nil) return [NSString new];
    return [NSString stringWithUTF8String:unityString_];
}

@end
