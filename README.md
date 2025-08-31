
## Scripts
- `SafeAreaFitter.cs` — Ajusta anchors al `Screen.safeArea`.
- `LinkOpener.cs` — Método `OpenURL()` para botones de enlace.
- `WindowController.cs` — Callbacks de los 3 botones inferiores.
- `IconHoverEffect.cs`  — Color + zoom suave en hover.

## Íconos
- Coloca PNGs en `Assets/Sprites/`.
- En cada PNG: **Texture Type = Sprite (2D and UI)** → Apply.
- Asigna en `Icon1–Icon4` (campo **Source Image** del componente **Image**).

## Enlaces sugeridos
- Left: `https://docs.unity3d.com/`, `https://assetstore.unity.com/`, `https://learn.unity.com/`
- Right: `https://www.febucci.com/2018/10/unity-ui-tutorial/`, `https://github.com/`, `https://learn.unity.com/path-finder`

## Cómo probar
1. Abrir la escena (p. ej. `SampleScene`) y presionar **Play**.
2. Cambiar resolución en la pestaña **Game** (16:9, 9:16, 4:3).
3. Probar:
   - Enlaces laterales → abren navegador.
   - **Acción 1** → oculta/muestra la grilla.
   - **Acción 2** → cambia color del panel Window.
   - **Salir** → cierra (en Editor, sale del Play).

## Configuración Git recomendada
- *Edit → Project Settings → Editor*:  
  - **Version Control:** Visible Meta Files  
  - **Asset Serialization:** Force Text

## Créditos / Apoyos
- FEBUCCI (2018). *Cómo crear una interfaz de usuario para todas las resoluciones*. https://www.febucci.com/2018/10/unity-ui-tutorial/
