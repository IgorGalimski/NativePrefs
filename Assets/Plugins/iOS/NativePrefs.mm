#import "IOSUnityBridge.h"

extern "C"{
    bool HasInternal(const char* key) {
        NSString *keyString = [IOSUnityBridge ConvertNSStringFromUnityString:key];
        if (keyString.length > 0) {
            return ([[NSUserDefaults standardUserDefaults] objectForKey:keyString] != nil);
        }
        
        return false;
    }
}


extern "C"{
    void DeleteInternal(const char* key) {
        NSString *keyString = [IOSUnityBridge ConvertNSStringFromUnityString:key];
        if (keyString.length > 0) {
            [[NSUserDefaults standardUserDefaults] removeObjectForKey:keyString];
        }
    }
}

extern "C"{
    void SaveDoubleInternal(const char* key, const double value) {
        NSString *keyString = [IOSUnityBridge ConvertNSStringFromUnityString:key];
        if (keyString.length > 0) {
            [[NSUserDefaults standardUserDefaults] setDouble:value forKey:keyString];
        }
    }
}

extern "C"{
    double GetDoubleInternal(const char* key) {
        NSString *keyString = [IOSUnityBridge ConvertNSStringFromUnityString:key];
        if (keyString.length > 0) {
            return [[NSUserDefaults standardUserDefaults] doubleForKey:keyString];
        }
        
        return 0;
    }
}

extern "C"{
    void SaveIntInternal(const char* key, const int value) {
        NSString *keyString = [IOSUnityBridge ConvertNSStringFromUnityString:key];
        if (keyString.length > 0) {
            [[NSUserDefaults standardUserDefaults] setInteger:value forKey:keyString];
        }
    }
}

extern "C"{
    int GetIntInternal(const char* key) {
        NSString *keyString = [IOSUnityBridge ConvertNSStringFromUnityString:key];
        if (keyString.length > 0) {
            return [[NSUserDefaults standardUserDefaults] integerForKey:keyString];
        }
        
        return 0;
    }
}

extern "C"{
    void SaveBoolInternal(const char* key, const bool value) {
        NSString *keyString = [IOSUnityBridge ConvertNSStringFromUnityString:key];
        if (keyString.length > 0) {
            [[NSUserDefaults standardUserDefaults] setBool:value forKey:keyString];
        }
    }
}

extern "C"{
    bool GetBoolInternal(const char* key) {
        NSString *keyString = [IOSUnityBridge ConvertNSStringFromUnityString:key];
        if (keyString.length > 0) {
            return [[NSUserDefaults standardUserDefaults] boolForKey:keyString];
        }
        
        return 0;
    }
}

extern "C"{
    void SaveStringInternal(const char* key, const char* value) {
        NSString *keyString = [IOSUnityBridge ConvertNSStringFromUnityString:key];
        if (keyString.length > 0) {
            [[NSUserDefaults standardUserDefaults] setObject:[IOSUnityBridge ConvertNSStringFromUnityString:value] forKey:keyString];
        }
    }
}

extern "C"{
    const char* GetStringInternal(const char* key) {
        NSString *keyString = [NSString stringWithUTF8String: key];
        if (keyString.length > 0) {
            return [IOSUnityBridge ConvertUnityStringFromNSString:[[NSUserDefaults standardUserDefaults] objectForKey:keyString]];
        }
        
        return nil;
    }
}
