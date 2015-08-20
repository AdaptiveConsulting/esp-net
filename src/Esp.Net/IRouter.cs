#region copyright
// Copyright 2015 Keith Woods
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System;
using Esp.Net.ModelRouter;

namespace Esp.Net
{
    public interface IRouter : IModelSubject, IEventSubject, IEventPublisher
    {
        void RegisterModel<TModel>(object modelId, TModel model);
        void RegisterModel<TModel>(object modelId, TModel model, IPreEventProcessor<TModel> preEventProcessor);
        void RegisterModel<TModel>(object modelId, TModel model, IPostEventProcessor<TModel> postEventProcessor);
        void RegisterModel<TModel>(object modelId, TModel model, IPreEventProcessor<TModel> preEventProcessor, IPostEventProcessor<TModel> postEventProcessor);
        void RemoveModel(object modelId);
        IRouter<TModel> CreateModelRouter<TModel>(object modelId);
        IRouter<TSubModel> CreateModelRouter<TModel, TSubModel>(object modelId, Func<TModel, TSubModel> subModelSelector);
    }
}