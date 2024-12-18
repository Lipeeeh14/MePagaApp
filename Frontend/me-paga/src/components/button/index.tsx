import { 
    ActivityIndicator,
    TextProps,
    Text,
    TouchableOpacity, 
    TouchableOpacityProps 
} from "react-native";

import { IconProps as TablerIconProps } from "@tabler/icons-react-native";

import { style as styleProps } from "./styles";
import { colors } from "@/styles/theme";
import React from "react";

type ButtonProps = TouchableOpacityProps & {
    isLoading?: boolean;
}

function Button({ children, style, isLoading = false, ...rest }: ButtonProps) {
    return (
        <TouchableOpacity 
            style={[styleProps.container, style]} 
            activeOpacity={0.8}
            disabled={isLoading} 
            {...rest}>
            {
                isLoading ? <ActivityIndicator size="small" color={colors.primary} /> : children
            }
        </TouchableOpacity>
    );
}

function Title({ children }: TextProps) {
    return (
        <Text style={styleProps.title}>{children}</Text>
    );
}

type IconProps = {
    icon: React.ComponentType<TablerIconProps>;
}

function Icon({ icon: Icon }: IconProps) {
    return (
        <Icon size={24} />
    );
}

Button.Title = Title;
Button.Icon = Icon;

export { Button }