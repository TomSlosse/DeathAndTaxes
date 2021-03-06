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
using Articy.Unity.Constraints;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.Project_Of_Death.Features
{
    
    
    public class task_random_profile_generatorFeatureConstraint
    {
        
        private Boolean mLoadedConstraints;
        
        private EnumConstraint mProfile_generate_occupation;
        
        private NumberConstraint mProfile_generate_older_than;
        
        private NumberConstraint mProfile_generate_younger_than;
        
        private NumberConstraint mProfile_generate_ecology_value_min;
        
        private NumberConstraint mProfile_generate_peace_value_min;
        
        private NumberConstraint mProfile_generate_healthcare_value_min;
        
        private NumberConstraint mProfile_generate_prosperity_value_min;
        
        private BooleanConstraint mProfile_generate_any_random;
        
        private NumberConstraint mProfile_generate_ecology_value_max;
        
        private NumberConstraint mProfile_generate_peace_value_max;
        
        private NumberConstraint mProfile_generate_healthcare_value_max;
        
        private NumberConstraint mProfile_generate_prosperity_value_max;
        
        private EnumConstraint mProfile_generate_spare_death_both;
        
        public EnumConstraint profile_generate_occupation
        {
            get
            {
                EnsureConstraints();
                return mProfile_generate_occupation;
            }
        }
        
        public NumberConstraint profile_generate_older_than
        {
            get
            {
                EnsureConstraints();
                return mProfile_generate_older_than;
            }
        }
        
        public NumberConstraint profile_generate_younger_than
        {
            get
            {
                EnsureConstraints();
                return mProfile_generate_younger_than;
            }
        }
        
        public NumberConstraint profile_generate_ecology_value_min
        {
            get
            {
                EnsureConstraints();
                return mProfile_generate_ecology_value_min;
            }
        }
        
        public NumberConstraint profile_generate_peace_value_min
        {
            get
            {
                EnsureConstraints();
                return mProfile_generate_peace_value_min;
            }
        }
        
        public NumberConstraint profile_generate_healthcare_value_min
        {
            get
            {
                EnsureConstraints();
                return mProfile_generate_healthcare_value_min;
            }
        }
        
        public NumberConstraint profile_generate_prosperity_value_min
        {
            get
            {
                EnsureConstraints();
                return mProfile_generate_prosperity_value_min;
            }
        }
        
        public BooleanConstraint profile_generate_any_random
        {
            get
            {
                EnsureConstraints();
                return mProfile_generate_any_random;
            }
        }
        
        public NumberConstraint profile_generate_ecology_value_max
        {
            get
            {
                EnsureConstraints();
                return mProfile_generate_ecology_value_max;
            }
        }
        
        public NumberConstraint profile_generate_peace_value_max
        {
            get
            {
                EnsureConstraints();
                return mProfile_generate_peace_value_max;
            }
        }
        
        public NumberConstraint profile_generate_healthcare_value_max
        {
            get
            {
                EnsureConstraints();
                return mProfile_generate_healthcare_value_max;
            }
        }
        
        public NumberConstraint profile_generate_prosperity_value_max
        {
            get
            {
                EnsureConstraints();
                return mProfile_generate_prosperity_value_max;
            }
        }
        
        public EnumConstraint profile_generate_spare_death_both
        {
            get
            {
                EnsureConstraints();
                return mProfile_generate_spare_death_both;
            }
        }
        
        public virtual void EnsureConstraints()
        {
            if ((mLoadedConstraints == true))
            {
                return;
            }
            mLoadedConstraints = true;
            mProfile_generate_occupation = new Articy.Unity.Constraints.EnumConstraint(false, "BySortIndex");
            mProfile_generate_older_than = new Articy.Unity.Constraints.NumberConstraint(18D, 2000D, 0, 0, 0, "years");
            mProfile_generate_younger_than = new Articy.Unity.Constraints.NumberConstraint(18D, 2000D, 0, 0, 0, "years");
            mProfile_generate_ecology_value_min = new Articy.Unity.Constraints.NumberConstraint(-100D, 100D, 0, 0, 0, null);
            mProfile_generate_peace_value_min = new Articy.Unity.Constraints.NumberConstraint(-100D, 100D, 0, 0, 0, null);
            mProfile_generate_healthcare_value_min = new Articy.Unity.Constraints.NumberConstraint(-100D, 100D, 0, 0, 0, null);
            mProfile_generate_prosperity_value_min = new Articy.Unity.Constraints.NumberConstraint(-100D, 100D, 0, 0, 0, null);
            mProfile_generate_any_random = new Articy.Unity.Constraints.BooleanConstraint(false);
            mProfile_generate_ecology_value_max = new Articy.Unity.Constraints.NumberConstraint(-100D, 100D, 0, 0, 0, null);
            mProfile_generate_peace_value_max = new Articy.Unity.Constraints.NumberConstraint(-100D, 100D, 0, 0, 0, null);
            mProfile_generate_healthcare_value_max = new Articy.Unity.Constraints.NumberConstraint(-100D, 100D, 0, 0, 0, null);
            mProfile_generate_prosperity_value_max = new Articy.Unity.Constraints.NumberConstraint(-100D, 100D, 0, 0, 0, null);
            mProfile_generate_spare_death_both = new Articy.Unity.Constraints.EnumConstraint(false, "BySortIndex");
        }
    }
}
