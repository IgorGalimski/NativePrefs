package com.igorgalimski;

import android.content.Context;
import android.content.SharedPreferences;

import com.unity3d.player.UnityPlayer;

public class NativePrefs {

    static final SharedPreferences prefs = UnityPlayer.currentActivity.getSharedPreferences(UnityPlayer.currentActivity.getPackageName(), Context.MODE_PRIVATE);
    static final SharedPreferences.Editor editor = prefs.edit();

    public static boolean Has(final String key) {
        return prefs.contains(key);
    }

    public static void Delete(final String key) {
        final SharedPreferences.Editor editor = prefs.edit();
        editor.remove(key).apply();
    }
    
    public static void SaveDouble(final String key, final double value) {
        editor.putLong(key, Double.doubleToRawLongBits(value)).apply();
    }

    public static double GetDouble(final String key) {
        return Double.longBitsToDouble(prefs.getLong(key, 0));
    }
    
    public static int GetInt(final String key) {
        return prefs.getInt(key, 0);
    }

    public static void SaveInt(final String key, final int value) {
        editor.putInt(key, value).apply();
    }
    
    public static boolean GetBool(String dataKey) {
        return prefs.getBoolean(dataKey, false);
    }

    public static void SaveBool(final String key, final boolean value) {
        editor.putBoolean(key, value).apply();
    }
    
    public static String GetString(final String dataKey) {
        return prefs.getString(dataKey, null);
    }

    public static void SaveString(final String key, final String value) {
        editor.putString(key, value).apply();
    }
}