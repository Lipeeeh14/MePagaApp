import { colors } from "@/styles/colors";
import { ActivityIndicator } from "react-native";
import { style } from "./styles";

export function Loading() {
    return (
        <ActivityIndicator color={colors.primary} style={style.container} />
    );
}