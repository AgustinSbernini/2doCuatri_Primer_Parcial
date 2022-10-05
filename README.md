<h1 class="code-line" data-line-start=0 data-line-end=1 ><a id="Cruceros_AguasVivas_0"></a>Cruceros AguasVivas</h1>
<hr>
<h2 class="code-line" data-line-start=2 data-line-end=3 ><a id="Presentacin_2"></a>Presentación</h2>
<pre><code>Soy Agustin Sbernini, estudiante de la carrera de Técnico Superior en Programación en la UTN FRA. 
Este proyecto representa el primer parcial de Laboratorio II. 
Durante la realización del mismo aprendí a usar diversasherramientas de los Forms las cuales se presentaron desafiantes 
Ya que tienen varias limitaciones o especificaciones difíciles de comprender hasta estudiarlas en profundidad. 
Además aprendí sobre mi y como me desenvuelvo frente a desafios extensos. Uno de mis grandes errores el cual limitó 
El desempeño global del parcial fue la perdida de tiempo en intentar realizar ciertas partes del trabajo a mi manera 
Para darle mi impronta cuando podría solucionar de otras maneras más sencillas o ser muy minucioso con detalles que 
No aportan lo equivalente. Para futuros proyectos intentaré en efocar mi tiempo y esfuerzo en completar la funcionalidad 
General, luego involucrarme en los detalles mas precisos.
</code></pre>
<hr>
<h2 class="code-line" data-line-start=7 data-line-end=8 ><a id="Resumen_7"></a>Resumen</h2>
<ul>
<li class="has-line-data" data-line-start="8" data-line-end="9">Dentro del Indice principal se pueden visualizar 3 tablas: La primera muestra todos los viajes creados actualmente. Al hacer click en alguno de los viajes se visualiza en la siguiente tabla el crucero que esta asignado a dicho viaje y la lista de pasajeros que lo abordan.</li>
<li class="has-line-data" data-line-start="9" data-line-end="11">A la derecha de las tablas hay 4 botones: la función del primero es Crear un viaje nuevo, donde se deberá rellenar la fecha de salida, se le deberá asignar un crucero y un destino. Un mismo crucero no podrá superponer dos viajes, ni podrá zarpar los días anteriores hasta un máximo de 15 o 30 días (si desea hacer un viaje regional o extraregional respectivamente). La función del segundo permite vender un pasaje donde se deberá rellenar todos los datos necesarios tanto del viaje al cual se desea ir como del pasajero en si. El tercero brinda información detallada de cada viaje, de su crucero y de su lista de pasajeros, podrás elegir antes de ingresar al formulario cual deseas visualizar y dentro del mismo también se podrá elegir. El cuarto botón muestra un formulario que contiene otros 3 botones, cada uno de estos sirve para ver el historial que cargado hasta el momento pudiendo visualizar (dependiendo el botón que elija) los cruceros con más horas viajadas, los destinos que más facturación realizaron y los pasajeros que mas viajes realizaron.</li>
</ul>
<hr>
<h2 class="code-line" data-line-start=12 data-line-end=13 ><a id="Diagrama_de_Clases_12"></a>Diagrama de Clases</h2>
<p class="has-line-data" data-line-start="13" data-line-end="14"><img src="https://www.dropbox.com/s/pgldusefgm5lhxr/Diagrama%20de%20clases.png?dl=0&amp;raw=1" alt="Diagrama de clases.png"></p>
<hr>
<ul>
<li class="has-line-data" data-line-start="16" data-line-end="18">
<p class="has-line-data" data-line-start="16" data-line-end="17"><em>Tema Uno:</em> Se utiliza a lo largo de todo el proyecto operadores lógicos, iteraciones y diversos tipos de datos.</p>
</li>
<li class="has-line-data" data-line-start="18" data-line-end="20">
<p class="has-line-data" data-line-start="18" data-line-end="19"><em>Tema Dos:</em> Utilice atributos estáticos dentro de la clase viaje ya que los valores eran los mismos para todos los objetos que se instancien y necesitaba acceder a estos valores sin acceder a través de un objeto. También propiedades estáticas para acceder a dichos atributos. Y métodos estáticos los utilicé principalmente para sobreescribir los operadores y los métodos estáticos de object.</p>
</li>
<li class="has-line-data" data-line-start="20" data-line-end="22">
<p class="has-line-data" data-line-start="20" data-line-end="21"><em>Tema Tres:</em> La programación orientada a objetos en la base del proyecto. Como puede observarse en el diagrama de clases la clase Viaje y la clase Crucero son las más extensas y relevantes, ya que desde ellas se administra toda la información que se utiliza en todos los formularios que componen el trabajo.</p>
</li>
<li class="has-line-data" data-line-start="22" data-line-end="24">
<p class="has-line-data" data-line-start="22" data-line-end="23"><em>Tema Cuatro:</em> Utilice las sobrecargas principalmente en los constructores y en los operadores.</p>
</li>
<li class="has-line-data" data-line-start="24" data-line-end="26">
<p class="has-line-data" data-line-start="24" data-line-end="25"><em>Tema Cinco:</em> Utilice Windows Forms para representar gráficamente el proyecto. En su mayoría utilice Formularios Modales ya que era relevante no perder el foco de la nueva ventana que se abría para completar su funcionamiento. No utilice Formularios MDI pero utilicé paneles para mostrar el historial de registros ya que cumplía mejor su rol.</p>
</li>
<li class="has-line-data" data-line-start="26" data-line-end="28">
<p class="has-line-data" data-line-start="26" data-line-end="27"><em>Tema Seis:</em> Se implementa únicamente Listas Genéricas, entre ellas List fue la más relevante ya que me permitia recorrer e interactuar con sus indices, agregando, quitando o modificando sus elementos dinamicamente. También utilicé un Dictionary para guardar el historial de registro ya que en cada caso se guardaba una clave y un valor unicamente.</p>
</li>
<li class="has-line-data" data-line-start="28" data-line-end="30">
<p class="has-line-data" data-line-start="28" data-line-end="29"><em>Tema Siete:</em> Encapsulamiento se puede visualizar principalmente a la hora de usar Getters en la mayoría de las clases permitiendo únicamente acceder al dato que guardan los objetos creados, impidiendo la modificación. Setters utilicé en la clase Viaje donde los camarotes y la bodega iba variando dependiendo de los pasajeros que integren el viaje. También utilicé 4 enumerados.</p>
</li>
<li class="has-line-data" data-line-start="30" data-line-end="32">
<p class="has-line-data" data-line-start="30" data-line-end="31"><em>Tema Ocho:</em> Se dió uso de herencia en la creación de los formularios utilizados en el historial de registros ya que los 3 utilizados eran casi iguales, solo variaba su lógica, por lo tanto heredé la parte gráfica desde un formulario base.</p>
</li>
<li class="has-line-data" data-line-start="32" data-line-end="33">
<p class="has-line-data" data-line-start="32" data-line-end="33"><em>Tema Nueve:</em> Polimorfismo se utilizó a la hora de sobreescribir los métodos estáticos derivados de object, principalmente ToString y en menor medida Equals (utilizado internamente por la función Contains). Intente usar Abstract para la herencia de formularios pero me contrajo más problemas que soluciones, por lo que terminé decidiendo no utilizar.</p>
</li>
</ul>