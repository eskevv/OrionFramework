using Microsoft.Xna.Framework;
using OrionFramework.Helpers;

namespace OrionFramework.Particles.Emitters;

public class MouseEmitter : IEmitter
{
    private int _varianceX;
    private int _varianceY;

    public Vector2 EmitPosition => GetPosition();

    private Vector2 GetPosition()
    {
        var cursor = Input.Input.ScreenCursor;

        if (_varianceX == 0 && _varianceY == 0)
            return cursor;

        float x = cursor.X + OrionHelp.RandomFloat(-_varianceX, _varianceX);
        float y = cursor.Y + OrionHelp.RandomFloat(-_varianceY, _varianceY);
        return new Vector2(x, y);
    }

    public MouseEmitter(int varianceX, int varianceY)
    {
        _varianceX = varianceX;
        _varianceY = varianceY;
    }
}