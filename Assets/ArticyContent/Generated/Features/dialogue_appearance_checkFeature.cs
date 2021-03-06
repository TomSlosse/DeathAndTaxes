//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Project_Of_Death;
using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.Project_Of_Death.Features
{
    
    
    [Serializable()]
    public class dialogue_appearance_checkFeature : IArticyBaseObject, IPropertyProvider
    {
        
        [SerializeField()]
        private ArticyValueArticyScriptCondition mdialogue_appearance_condition = new ArticyValueArticyScriptCondition();
        
        [SerializeField()]
        private ArticyValueArticyScriptCondition mdialogue_appearance_instruction = new ArticyValueArticyScriptCondition();
        
        [SerializeField()]
        private UInt64 mOwnerId;
        
        [SerializeField()]
        private UInt32 mOwnerInstanceId;
        
        /// <summary>
        /// (put variables here to make conscience dialogue happen)
        /// </summary>
        public ArticyScriptCondition dialogue_appearance_condition
        {
            get
            {
                return mdialogue_appearance_condition.GetValue();
            }
            set
            {
                var oldValue = mdialogue_appearance_condition;
                mdialogue_appearance_condition.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "dialogue_appearance_check.dialogue_appearance_condition", oldValue.GetValue(), mdialogue_appearance_condition.GetValue());
            }
        }
        
        /// <summary>
        /// (put variable here if you need an instruction from the dialogue)
        /// </summary>
        public ArticyScriptCondition dialogue_appearance_instruction
        {
            get
            {
                return mdialogue_appearance_instruction.GetValue();
            }
            set
            {
                var oldValue = mdialogue_appearance_instruction;
                mdialogue_appearance_instruction.SetValue(value);
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "dialogue_appearance_check.dialogue_appearance_instruction", oldValue.GetValue(), mdialogue_appearance_instruction.GetValue());
            }
        }
        
        public UInt64 OwnerId
        {
            get
            {
                return mOwnerId;
            }
            set
            {
                mOwnerId = value;
            }
        }
        
        public UInt32 OwnerInstanceId
        {
            get
            {
                return mOwnerInstanceId;
            }
            set
            {
                mOwnerInstanceId = value;
            }
        }
        
        private void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.Project_Of_Death.Features.dialogue_appearance_checkFeature newClone = ((Articy.Project_Of_Death.Features.dialogue_appearance_checkFeature)(aClone));
            if ((dialogue_appearance_condition != null))
            {
                newClone.dialogue_appearance_condition = ((ArticyScriptCondition)(dialogue_appearance_condition.CloneObject(newClone, aFirstClassParent)));
            }
            if ((dialogue_appearance_instruction != null))
            {
                newClone.dialogue_appearance_instruction = ((ArticyScriptCondition)(dialogue_appearance_instruction.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.OwnerId = OwnerId;
        }
        
        public object CloneObject(object aParent, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.Project_Of_Death.Features.dialogue_appearance_checkFeature clone = new Articy.Project_Of_Death.Features.dialogue_appearance_checkFeature();
            CloneProperties(clone, aFirstClassParent);
            return clone;
        }
        
        public virtual bool IsLocalizedPropertyOverwritten(string aProperty)
        {
            return false;
        }
        
        #region property provider interface
        public void setProp(string aProperty, object aValue)
        {
            if ((aProperty == "dialogue_appearance_condition"))
            {
                dialogue_appearance_condition = ((ArticyScriptCondition)(aValue));
                return;
            }
            if ((aProperty == "dialogue_appearance_instruction"))
            {
                dialogue_appearance_instruction = ((ArticyScriptCondition)(aValue));
                return;
            }
        }
        
        public Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if ((aProperty == "dialogue_appearance_condition"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(dialogue_appearance_condition);
            }
            if ((aProperty == "dialogue_appearance_instruction"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(dialogue_appearance_instruction);
            }
            return null;
        }
        #endregion
    }
}
