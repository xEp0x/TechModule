<?php

/* :task:create.html.twig */
class __TwigTemplate_c517018ef399f95051010888a14e5980d898b696f6e7aa2f05f5a4a39fa0338c extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", ":task:create.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_06198e33c911d36f836cb932acc6e88690f62979b91e39ccd53ebd5d394830c6 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_06198e33c911d36f836cb932acc6e88690f62979b91e39ccd53ebd5d394830c6->enter($__internal_06198e33c911d36f836cb932acc6e88690f62979b91e39ccd53ebd5d394830c6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":task:create.html.twig"));

        $__internal_ad0852109298bc3a5fd039f068397d4a2c055b20fed89a3ad40fcd5f3e9a26df = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ad0852109298bc3a5fd039f068397d4a2c055b20fed89a3ad40fcd5f3e9a26df->enter($__internal_ad0852109298bc3a5fd039f068397d4a2c055b20fed89a3ad40fcd5f3e9a26df_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":task:create.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_06198e33c911d36f836cb932acc6e88690f62979b91e39ccd53ebd5d394830c6->leave($__internal_06198e33c911d36f836cb932acc6e88690f62979b91e39ccd53ebd5d394830c6_prof);

        
        $__internal_ad0852109298bc3a5fd039f068397d4a2c055b20fed89a3ad40fcd5f3e9a26df->leave($__internal_ad0852109298bc3a5fd039f068397d4a2c055b20fed89a3ad40fcd5f3e9a26df_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_f68c6750e78499c342809a3673b7c5b3681f285c83dd7569cbbf709862053f2f = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_f68c6750e78499c342809a3673b7c5b3681f285c83dd7569cbbf709862053f2f->enter($__internal_f68c6750e78499c342809a3673b7c5b3681f285c83dd7569cbbf709862053f2f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_3cc02d864a7ae116d4bdde44c3830b14e32993e52563e62a79886b274fd7fe7f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_3cc02d864a7ae116d4bdde44c3830b14e32993e52563e62a79886b274fd7fe7f->enter($__internal_3cc02d864a7ae116d4bdde44c3830b14e32993e52563e62a79886b274fd7fe7f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "    <div id=\"create-wrapper\">
        <section class=\"create\">
            <article>
                <form action=\"";
        // line 7
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("create");
        echo "\" method=\"POST\">
                    <div class=\"row\">
                        <label for=\"task\">Task:</label>
                        <input type=\"text\" id=\"task\" name=\"task[title]\">
                    </div>
                    <div class=\"row\">
                        <label for=\"comments\">Comments:</label>
                        <textarea id=\"comments\" name=\"task[comments]\"></textarea>
                    </div>

                    ";
        // line 17
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "

                    <button type=\"submit\">Create</button>
                </form>
            </article>
        </section>
    </div>
";
        
        $__internal_3cc02d864a7ae116d4bdde44c3830b14e32993e52563e62a79886b274fd7fe7f->leave($__internal_3cc02d864a7ae116d4bdde44c3830b14e32993e52563e62a79886b274fd7fe7f_prof);

        
        $__internal_f68c6750e78499c342809a3673b7c5b3681f285c83dd7569cbbf709862053f2f->leave($__internal_f68c6750e78499c342809a3673b7c5b3681f285c83dd7569cbbf709862053f2f_prof);

    }

    public function getTemplateName()
    {
        return ":task:create.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  67 => 17,  54 => 7,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
    <div id=\"create-wrapper\">
        <section class=\"create\">
            <article>
                <form action=\"{{ path('create') }}\" method=\"POST\">
                    <div class=\"row\">
                        <label for=\"task\">Task:</label>
                        <input type=\"text\" id=\"task\" name=\"task[title]\">
                    </div>
                    <div class=\"row\">
                        <label for=\"comments\">Comments:</label>
                        <textarea id=\"comments\" name=\"task[comments]\"></textarea>
                    </div>

                    {{ form_row(form._token) }}

                    <button type=\"submit\">Create</button>
                </form>
            </article>
        </section>
    </div>
{% endblock %}", ":task:create.html.twig", "D:\\PROJECTS\\Software Technologies\\17. ExamPreparationI\\PHP Skeleton\\app/Resources\\views/task/create.html.twig");
    }
}
