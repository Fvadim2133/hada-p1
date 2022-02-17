P1b _______________________________________________________________________________

P1 ¿Qué rama se ha subido exactamente?
-Se ha subido master (si quiero subir otra tengo que hacer git checkout)

P2 ¿Qué pasa al utilizar la opción Comparar con la versión no modificada? 
-Me muestra los el fichero modificado y el no modificado, donde resaltan las diferencias entre uno y el otro

P3 ¿Y ahora ves algún cambio en el repositorio remoto? ¿Por qué? 
-El cambio es que se ha sincronizarlo el archivo HadaP1.cs con el repositorio remoto

P4 ¿Qué significa "Confirmar todo” y cuál sería el comando git equivalente? 
-Guarda los cambios en el repositorio local. Su equivalente es $git commit.  

P5 ¿Qué significa "Confirmar todo e insertar” y cuál sería el comando git equivalente? 
-Hace add y luego commit , para guardarle en el repo local. Su equivalente es $git commit -a  y $git push   
   
P6 ¿Qué significa "Confirmar todo y sincronizar” cuál sería el comando git equivalente?  
-Hace todo lo que hace "confirmar e insertar" y luego sincroniza el repo local con lo que tiene el remoto
(las confirmaciones de entrada y salida se sincronizan)

P7 ¿Cuál es la diferencia entre pulsar Sincronizar o Extraer? ¿Cuáles serían los comandos git equivalentes? 
-Sincronizar actualiza los archivos del repositorio remoto con los del local. 
Extraer trae los commits realizados en el repositorio remoto para aplicarlos al local.
  