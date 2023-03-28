# RETO API
- Nunca antes habia creado una Api en .Net, mayormente habia realizado aplicaciones CRUD o pequeños programas. Investigando y googleando esta fue la forma mas accesible que encontré y funcionó.
# Funcionamiento
- Incluí un metodo Get para visulizar la información ya cargada antes de realizar modificaciones con Patch. 
- Asi es como completo el Json desde el Patch.
- [
    {
    "path": "/informacion",
    "op": "replace",
    "value": "NUEVA INFORMACION"
  }
]
