# TestCalculadora-xUnit
## Calculadora con un método que recibe un string y retorna un entero.
### Casos a testear:
1. Si envio un string vacio debera retornar 0.
2. Si envio 2 numeros separados por coma debera retornar la suma de los mismos.
3. Si envio cualquier cantidad de numeros separados por coma debera retornar la suma de los mismos.
4. Si envio cualquier cantidad de numeros separados por cualquier delimitador debera retornarme la suma de los numeros.
5. Si envio numeros negativos debera retornarme una exception.
6. Si envio numeros sin separadores válidos debera retornar una exception.
7. Si envio un caracter no valido como numero separado por coma debera retornar una exception.
8. Si envio numeros mayores a 100 debera no tenerlos en cuenta para la suma y solo tener en cuenta los positivos.
