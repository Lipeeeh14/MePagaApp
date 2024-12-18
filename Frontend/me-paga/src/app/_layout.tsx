import { Stack } from "expo-router";
import { GestureHandlerRootView } from "react-native-gesture-handler";

import {
    useFonts,
    NotoSans_600SemiBold,
    NotoSans_400Regular,
    NotoSans_500Medium,
    NotoSans_700Bold,
} from '@expo-google-fonts/noto-sans';
import { colors } from "../styles/theme";
import { Loading } from "@/components/loading";


export default function Layout() {
    const [fontsLoaded] = useFonts({
        NotoSans_600SemiBold,
        NotoSans_400Regular,
        NotoSans_500Medium,
        NotoSans_700Bold,
    });

    if (!fontsLoaded) {
        return <Loading />;
    }

    return (
        <GestureHandlerRootView style={{ flex: 1 }}>
            <Stack 
                screenOptions={{
                    headerShown: false,
                    contentStyle: { backgroundColor: colors.background },
                }}
            />
        </GestureHandlerRootView>
    );
}