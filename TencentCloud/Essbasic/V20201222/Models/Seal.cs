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

namespace TencentCloud.Essbasic.V20201222.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Seal : AbstractModel
    {
        
        /// <summary>
        /// 电子印章ID
        /// </summary>
        [JsonProperty("SealId")]
        public string SealId{ get; set; }

        /// <summary>
        /// 电子印章名称
        /// </summary>
        [JsonProperty("SealName")]
        public string SealName{ get; set; }

        /// <summary>
        /// 电子印章类型
        /// </summary>
        [JsonProperty("SealType")]
        public string SealType{ get; set; }

        /// <summary>
        /// 电子印章来源：
        /// CREATE - 通过图片上传
        /// GENERATE - 通过文字生成
        /// </summary>
        [JsonProperty("SealSource")]
        public string SealSource{ get; set; }

        /// <summary>
        /// 电子印章创建者
        /// </summary>
        [JsonProperty("Creator")]
        public Caller Creator{ get; set; }

        /// <summary>
        /// 电子印章创建时间戳
        /// </summary>
        [JsonProperty("CreatedOn")]
        public long? CreatedOn{ get; set; }

        /// <summary>
        /// 电子印章所有人
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 电子印章URL
        /// </summary>
        [JsonProperty("FileUrl")]
        public FileUrl FileUrl{ get; set; }

        /// <summary>
        /// 是否为默认印章，false-非默认，true-默认
        /// </summary>
        [JsonProperty("DefaultSeal")]
        public bool? DefaultSeal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SealId", this.SealId);
            this.SetParamSimple(map, prefix + "SealName", this.SealName);
            this.SetParamSimple(map, prefix + "SealType", this.SealType);
            this.SetParamSimple(map, prefix + "SealSource", this.SealSource);
            this.SetParamObj(map, prefix + "Creator.", this.Creator);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamObj(map, prefix + "FileUrl.", this.FileUrl);
            this.SetParamSimple(map, prefix + "DefaultSeal", this.DefaultSeal);
        }
    }
}

