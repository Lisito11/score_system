import 'package:flutter/material.dart';
import 'package:score_system/src/routes/routes.dart';
import 'package:score_system/src/screens/login/login_screen.dart';

void main() {
  WidgetsFlutterBinding.ensureInitialized();
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Score System',
      debugShowCheckedModeBanner: false,
      initialRoute: "login",
      routes: getApplicationRoutes(),
      onGenerateRoute: (RouteSettings settings){
        return MaterialPageRoute(
            builder: (BuildContext context) => const LoginScreen()
        );
      },
    );
  }
}
