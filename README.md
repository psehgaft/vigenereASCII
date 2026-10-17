# vigenereASCII

Aplicación de escritorio en C# (Windows Forms) que cifra y descifra texto plano
aplicando una variante del cifrado de Vigenère sobre una tabla ASCII extendida
personalizada.

## ¿Qué hace?

- **Abrir archivo**: carga un archivo de texto plano en el panel
  "Texto original".
- **cifrar**: recorre cada carácter y lo transforma con la función `3x + 2`,
  ajustada al rango de la tabla cuando se sale de él, usando la tabla de
  correspondencia carácter ↔ código. El resultado aparece en
  "Texto cifrado".
- **descifrar**: aplica la función inversa `(x − 2) / 3` para recuperar el
  texto original.
- **Guardar archivo**: exporta el texto cifrado a un archivo `.txt`.

La tabla cubre los códigos 33–137 (símbolos, dígitos, mayúsculas y
minúsculas) más caracteres extendidos del español: `ñ`, `á`, `é`, `í`, `ó`,
`ú` y sus mayúsculas. Los espacios se conservan sin cifrar.

> Nota: es un ejercicio didáctico de criptografía clásica, no un cifrado
> seguro para datos sensibles.

## Uso

1. Abre `vigenereASCII.sln` en Visual Studio.
2. Compila la solución (Ctrl + Mayús + B).
3. Ejecuta la aplicación, abre un archivo de texto, cifra o descifra y
   guarda el resultado.

Requisitos: .NET Framework con Windows Forms (proyecto de escritorio Windows).

## Licencia

GPLv3 — ver el archivo [LICENSE](LICENSE).
