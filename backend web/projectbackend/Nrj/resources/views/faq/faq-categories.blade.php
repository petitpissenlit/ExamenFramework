@extends('layouts.app')

@section('content')
<div class="container">
    <h1>FAQ</h1>
    @if(Auth::user()->isAdmin())

        <div class="accordion" id="faqAccordion">
            @foreach ($categories as $category)
                <div class="accordion-item">
                    <h2 class="accordion-header" id="heading{{ $category->id }}">
                        <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#collapse{{ $category->id }}" aria-expanded="true" aria-controls="collapse{{ $category->id }}">
                            {{ $category->name }}
                        </button>
                    </h2>
                    <div id="collapse{{ $category->id }}" class="accordion-collapse collapse" aria-labelledby="heading{{ $category->id }}" data-bs-parent="#faqAccordion">
                        <div class="accordion-body">
                            <ul>
                                @foreach ($category->questions as $question)
                                    <li class="faq-question">
                                        <strong>{{ $question->question }}</strong><br>
                                        <div class="answer">
                                            {{ $question->answer }}
                                        </div>
                                    </li>
                                @endforeach
                            </ul>
                        </div>
                    </div>
                </div>
            @endforeach
        </div>
    @else
        <p>Je hebt geen toegang tot deze pagina.</p>
    @endif
</div>

    <script>
        const faqQuestions = document.querySelectorAll('.faq-question');

        faqQuestions.forEach(question => {
            question.addEventListener('click', () => {
                question.querySelector('.answer').classList.toggle('show');
            });
        });
    </script>
@endsection
