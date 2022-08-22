using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundToggle : ToggleOfSettings
{
    public override void Save()
    {
        Saver<SavableSoundSettings>.Save(new SavableSoundSettings(){IsSoundTurnOn = Toggle.isOn});
    }

    public override void TryLoad()
    {
        SavableSoundSettings savableSoundSettings = Loader<SavableSoundSettings>.Load(new SavableSoundSettings());
        ChangeStateOfToggle(savableSoundSettings,savableSoundSettings.IsSoundTurnOn);
    }    

}
