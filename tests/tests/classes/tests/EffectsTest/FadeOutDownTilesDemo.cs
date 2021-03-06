using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cocos2D;

namespace tests
{
    public class FadeOutDownTilesDemo : CCFadeOutDownTiles
    {
        public static CCActionInterval actionWithDuration(float t)
        {
            CCFadeOutDownTiles fadeout = new CCFadeOutDownTiles(new CCGridSize(16, 12), t);
            CCFiniteTimeAction back = fadeout.Reverse();
            CCDelayTime delay = new CCDelayTime (0.5f);

            return (CCActionInterval)(CCSequence.FromActions(fadeout, delay, back));
        }
    }
}
