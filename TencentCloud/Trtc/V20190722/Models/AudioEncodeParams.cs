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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AudioEncodeParams : AbstractModel
    {
        
        /// <summary>
        /// 音频采样率，取值为[48000, 44100]，单位是Hz。
        /// </summary>
        [JsonProperty("SampleRate")]
        public ulong? SampleRate{ get; set; }

        /// <summary>
        /// 音频声道数，取值范围[1,2]，1表示音频为单声道，2表示音频为双声道。
        /// </summary>
        [JsonProperty("Channel")]
        public ulong? Channel{ get; set; }

        /// <summary>
        /// 音频码率，取值范围[8,500]，单位为kbps。
        /// </summary>
        [JsonProperty("BitRate")]
        public ulong? BitRate{ get; set; }

        /// <summary>
        /// 音量，取值范围[0,300]。默认100，表示原始音量；0表示静音。
        /// </summary>
        [JsonProperty("Volume")]
        public ulong? Volume{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "BitRate", this.BitRate);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
        }
    }
}

