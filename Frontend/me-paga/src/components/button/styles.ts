import { StyleSheet } from "react-native";
import { colors, fontFamily } from "@/styles/theme";

export const style = StyleSheet.create({
    container: {
        height: 56,
        maxHeight: 56,
        borderRadius: 10,
        justifyContent: "center",
        alignItems: "center",
        flexDirection: "row",
        gap: 14,
        backgroundColor: colors.primary,
    },
    title: {
        color: colors.secondary,
        fontFamily: fontFamily.semiBold,
        fontSize: 16,
    }
});