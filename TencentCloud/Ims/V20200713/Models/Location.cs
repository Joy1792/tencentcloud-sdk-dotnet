/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ims.V20200713.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Location : AbstractModel
    {
        
        /// <summary>
        /// 左上角横坐标
        /// </summary>
        [JsonProperty("X")]
        public float? X{ get; set; }

        /// <summary>
        /// 左上角纵坐标
        /// </summary>
        [JsonProperty("Y")]
        public float? Y{ get; set; }

        /// <summary>
        /// 宽度
        /// </summary>
        [JsonProperty("Width")]
        public float? Width{ get; set; }

        /// <summary>
        /// 高度
        /// </summary>
        [JsonProperty("Height")]
        public float? Height{ get; set; }

        /// <summary>
        /// 检测框的旋转角度
        /// </summary>
        [JsonProperty("Rotate")]
        public float? Rotate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "X", this.X);
            this.SetParamSimple(map, prefix + "Y", this.Y);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Rotate", this.Rotate);
        }
    }
}

