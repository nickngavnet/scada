﻿/*
 * Copyright 2018 Mikhail Shiryaev
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : ScadaAdminCommon
 * Summary  : The class contains utility methods for Administrator and its libraries
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2018
 * Modified : 2018
 */

using System;

namespace Scada.Admin
{
    /// <summary>
    /// The class contains utility methods for Administrator and its libraries.
    /// <para>Класс, содержащий вспомогательные методы для Администратора и его библиотек.</para>
    /// </summary>
    public static class AdminUtils
    {
        /// <summary>
        /// Version of Administrator.
        /// </summary>
        public const string AppVersion = "5.5.0.0";

        /// <summary>
        /// Extension of a project file.
        /// </summary>
        public const string ProjectExt = ".rsproj";

        /// <summary>
        /// Determines that the application is running on Mono Framework.
        /// </summary>
        public static readonly bool IsRunningOnMono = Type.GetType("Mono.Runtime") != null;


        /// <summary>
        /// Identifies a nullable type.
        /// </summary>
        public static bool IsNullable(this Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
        }
    }
}