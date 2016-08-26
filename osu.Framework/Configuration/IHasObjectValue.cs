//Copyright (c) 2007-2016 ppy Pty Ltd <contact@ppy.sh>.
//Licensed under the MIT License - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

namespace osu.Framework.Configuration
{
    public interface IHasObjectValue
    {
        object ObjectValue { get; set; }

        bool Parse(object s);
    }
}