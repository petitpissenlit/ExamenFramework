<x-app-layout>
    <form method="POST" action="{{ route('new') }}">
        <x-slot name="header">
            <h2 class="font-semibold text-xl text-gray-800 dark:text-gray-200 leading-tight">
                {{ __('Onze categorieen') }}
            </h2>
        </x-slot>

        <div class="py-12">
            <div class="max-w-7xl mx-auto sm:px-6 lg:px-8">
                <div class="bg-white dark:bg-gray-800 overflow-hidden shadow-sm sm:rounded-lg">
                    <div class="p-6 text-gray-900 dark:text-gray-100">
                        <div>
                            <x-input-label for="title" :value="__('Title')" />
                            <x-text-input id="title" class="block mt-1 w-full" type="text" name="title" :value="old('title')" required autofocus />
                            <x-input-error :messages="$errors->get('title')" class="mt-2" />
                        </div>
                        <div>
                            <x-input-label for="message" :value="__('Message')" />
                            <x-text-input id="message" class="block mt-1 w-full" type="text-area" name="message" :value="old('message')" required autofocus />
                            <x-input-error :messages="$errors->get('message')" class="mt-2" />
                        </div>
                        <div>
                            <br>
                            <x-primary-button>
                                {{ __('Create post') }}
                            </x-primary-button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</x-app-layout>