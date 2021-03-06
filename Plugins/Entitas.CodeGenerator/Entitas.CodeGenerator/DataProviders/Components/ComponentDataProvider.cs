﻿using System;
using System.Reflection;

namespace Entitas.CodeGenerator {

    public class ComponentDataProvider : AbstractComponentDataProvider {

        public override bool IsEnabledByDefault { get { return true; } }

        public ComponentDataProvider() : this(Assembly.GetAssembly(typeof(IEntity)).GetTypes()) {
        }

        public ComponentDataProvider(Type[] types)
            : base(new IComponentDataProvider[] {
                new ComponentTypeComponentDataProvider(),
                new ComponentNameComponentDataProvider(),
                new MemberInfosComponentDataProvider(),
                new ContextsComponentDataProvider(),
                new IsUniqueComponentDataProvider(),
                new UniquePrefixComponentDataProvider(),
                new ShouldGenerateComponentComponentDataProvider(),
                new ShouldGenerateMethodsComponentDataProvider(),
                new ShouldGenerateComponentIndexComponentDataProvider(),
                new ShouldHideInBlueprintInspectorComponentDataProvider()
            }, types) {
        }
    }
}
