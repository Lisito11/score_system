import 'package:flutter/material.dart';
import 'package:score_system/src/screens/home_screen.dart';
import 'package:score_system/src/screens/login/login_admin_screen.dart';
import 'package:score_system/src/screens/login/login_screen.dart';
import 'package:score_system/src/screens/login/login_user_screen.dart';

Map<String, WidgetBuilder> getApplicationRoutes(){
  return <String,WidgetBuilder>{
    "/": (context) => const HomeScreen(),
    "login": (context) => const LoginScreen(),
    "login/admin": (context) => const LoginAdminScreen(),
    "login/user": (context) => const LoginUserScreen(),
  };
}